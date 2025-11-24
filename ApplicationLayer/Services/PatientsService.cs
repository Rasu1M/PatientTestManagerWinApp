using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Models;
using PatientTestManagerWinApp.ApplicationLayer.Services.Abstract;
using PatientTestManagerWinApp.Domain.Entities;
using PatientTestManagerWinApp.infrastructure.Persistence.Repository;

namespace PatientTestManagerWinApp.ApplicationLayer.Services
{
    public class PatientsService : IPatientsService
    {
        private readonly IBaseRepository<Patient> _patientsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PatientsService(IBaseRepository<Patient> patientsRepository,
                               IUnitOfWork unitOfWork)
        {
            _patientsRepository = patientsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<PatientDto>> CreateAsync(CreatePatientRequest request)
        {
            try
            {
                var patient = new Patient()
                {
                    Name = request.Name,
                    DateOfBirth = request.DateOfBirth,
                    Gender = request.Gender
                };

                await _patientsRepository.AddAsync(patient);
                await _unitOfWork.SaveChangesAsync(CancellationToken.None);

                var patientDto = new PatientDto()
                {
                    ID = patient.ID,
                    Name = patient.Name,
                    DateOfBirth = patient.DateOfBirth,
                    Gender = patient.Gender,
                    UpdatedAt = patient.UpdatedAt,
                };

                return Result<PatientDto>.Ok(patientDto);
            }
            catch (Exception ex)
            {
                // logging
                return Result<PatientDto>.Fail("Creating new patient failed");
            }
            finally
            {
                _unitOfWork.ClearTracker();
            }
        }

        public async Task<Result<bool>> DeleteAsync(int id)
        {
            try
            {
                await _patientsRepository.DeleteAsync(id);
                await _unitOfWork.SaveChangesAsync(CancellationToken.None);

                return Result<bool>.Ok(true);
            }
            catch (Exception ex)
            {
                // logging
                return Result<bool>.Fail("Deleting patient failed");
            }
            finally
            {
                _unitOfWork.ClearTracker();
            }
        }

        public async Task<Result<List<PatientDto>>> GetAsync(GetPatientsRequest request)
        {
            try
            {
                var patientQuery = _patientsRepository
                    .AsQueryable()
                    .OrderBy(e => e.CreatedAt);

                var patientList = await patientQuery.ToListAsync();

                var patientDtoList = new List<PatientDto>(patientList.Count);

                foreach (var patient in patientList)
                {
                    var patientDto = new PatientDto()
                    {
                        ID = patient.ID,
                        Name = patient.Name,
                        DateOfBirth = patient.DateOfBirth,
                        Gender = patient.Gender,
                        UpdatedAt = patient.UpdatedAt,
                    };
                    patientDtoList.Add(patientDto);
                }

                return Result<List<PatientDto>>.Ok(patientDtoList);
            }
            catch (Exception ex)
            {
                // logging
                return Result<List<PatientDto>>.Fail("Fetching patients info failed");
            }
            finally
            {
                _unitOfWork.ClearTracker();
            }
        }

        public async Task<Result<PatientDto>> UpdateAsync(UpdatePatientRequest request)
        {
            try
            {

                var patient = await _patientsRepository.GetAsync(request.ID);

                if (patient is null)
                {
                    return Result<PatientDto>.Fail("Updating patient failed. Patient can not be found");
                }

                patient.Name = request.Name;
                patient.Gender = request.Gender;
                patient.DateOfBirth = request.DateOfBirth;
                patient.UpdatedAt = DateTime.Now;

                _patientsRepository.Update(patient);
                await _unitOfWork.SaveChangesAsync(CancellationToken.None);

                var patientDto = new PatientDto()
                {
                    ID = patient.ID,
                    Name = patient.Name,
                    DateOfBirth = patient.DateOfBirth,
                    Gender = patient.Gender,
                    UpdatedAt = patient.UpdatedAt,
                };

                return Result<PatientDto>.Ok(patientDto);
            }
            catch (Exception ex)
            {
                // logging
                return Result<PatientDto>.Fail("Updating patient failed");
            }
            finally
            {
                _unitOfWork.ClearTracker();
            }
        }

        public async Task<Result<List<ReportDto>>> GetReport(GetReportRequest request)
        {
            try
            {
                string connectionString = $"Data Source={Path.Combine(AppContext.BaseDirectory, "PatientTestManager.db")}";

                string sqlQuery = @"
                                SELECT 
                                    p.Name AS PatientName,
                                    p.DateOfBirth,
                                    p.Gender,
                                    COUNT(t.ID) AS TotalTests,
                                    COALESCE(
                                                AVG(CASE WHEN t.IsWithinThreshold = 1 THEN 1.0 ELSE 0 END) * 100,
                                                0
                                            ) AS TestsWithinThresholdPercentage
                                FROM Patients p
                                LEFT JOIN Tests t ON p.ID = t.PatientID
                                AND t.PerformedOn >= @PerformedOnFrom
                                AND t.PerformedOn < @PerformedOnToExcluded
                                GROUP BY p.ID, p.Name, p.DateOfBirth, p.Gender, p.CreatedAt
                                ORDER BY p.CreatedAt
                                ";

                var results = new List<ReportDto>();

                using (var conn = new SqliteConnection(connectionString))
                using (var cmd = new SqliteCommand(sqlQuery, conn))
                {
                    await conn.OpenAsync();

                    cmd.Parameters.AddWithValue("@PerformedOnFrom", request.PerformedOnFrom);
                    cmd.Parameters.AddWithValue("@PerformedOnToExcluded", request.PerformedOnToExcluded);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            results.Add(new ReportDto
                            {
                                Name = reader["PatientName"].ToString()!,
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Gender = reader["Gender"].ToString()!,
                                TestCount = reader.GetInt32(reader.GetOrdinal("TotalTests")),
                                TestsWithinThresholdPercentage = reader.GetDecimal(reader.GetOrdinal("TestsWithinThresholdPercentage")).ToString("F2")
                            });
                        }
                    }
                }

                return Result<List<ReportDto>>.Ok(results);
            }
            catch (Exception ex)
            {
                // logging
                return Result<List<ReportDto>>.Fail("Preparing report data failed");
            }
        }
    }
}
