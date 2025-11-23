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
        }

        public async Task<PagedResult<PatientDto>> GetAsync(GetPatientsRequest request)
        {
            try
            {
                int patientsCount = 0;

                var patientQuery = _patientsRepository.AsQueryable();

                if (request.IncludePagination is true)
                {
                    patientsCount = await patientQuery.CountAsync();

                    patientQuery = patientQuery
                        .Skip((request.PageNumber - 1) * request.PageSize)
                        .Take(request.PageSize);
                }

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

                return PagedResult<PatientDto>.Ok(patientDtoList, request.PageNumber, request.PageSize, patientsCount);
            }
            catch (Exception ex)
            {
                // logging
                return PagedResult<PatientDto>.Fail("Fetching patients info failed");
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
        }
    }
}
