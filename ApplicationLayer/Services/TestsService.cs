using Microsoft.EntityFrameworkCore;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Tests;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Tests;
using PatientTestManagerWinApp.ApplicationLayer.Models;
using PatientTestManagerWinApp.ApplicationLayer.Services.Abstract;
using PatientTestManagerWinApp.Domain.Entities;
using PatientTestManagerWinApp.infrastructure.Persistence.Repository;

namespace PatientTestManagerWinApp.ApplicationLayer.Services
{
    public class TestsService : ITestsService
    {
        private readonly IBaseRepository<Test> _testsRepository;
        private readonly IBaseRepository<Patient> _patientsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TestsService(IBaseRepository<Test> testsRepository,
                            IBaseRepository<Patient> patientsRepository,
                            IUnitOfWork unitOfWork)
        {
            _testsRepository = testsRepository;
            _patientsRepository = patientsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<TestDto>> CreateAsync(CreateTestRequest request)
        {
            try
            {
               var patient = await _patientsRepository.GetAsync(request.PatientID);

                if (patient is null)
                {
                    return Result<TestDto>.Fail("Creating new test failed. Related patient can not be found");
                }

                var test = new Test()
                {
                    PatientID = request.PatientID,
                    Name = request.Name,
                    PerformedOn = request.PerformedOn,
                    Result = request.Result,
                    IsWithinThreshold = request.IsWithinThreshold
                };

                await _testsRepository.AddAsync(test);
                await _unitOfWork.SaveChangesAsync(CancellationToken.None);

                var testDto = new TestDto()
                {
                    ID = test.ID,
                    PatientID = test.PatientID,
                    Name = test.Name,
                    PerformedOn = test.PerformedOn,
                    Result = test.Result,
                    IsWithinThreshold = test.IsWithinThreshold,
                    UpdatedAt = test.UpdatedAt
                };

                return Result<TestDto>.Ok(testDto);
            }
            catch (Exception ex)
            {
                // logging
                return Result<TestDto>.Fail("Creating new test failed");
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
                await _testsRepository.DeleteAsync(id);
                await _unitOfWork.SaveChangesAsync(CancellationToken.None);

                return Result<bool>.Ok(true);
            }
            catch (Exception ex)
            {
                // logging
                return Result<bool>.Fail("Deleting test failed");
            }
            finally
            {
                _unitOfWork.ClearTracker();
            }
        }

        public async Task<Result<List<TestDto>>> GetAsync(GetTestsRequest request)
        {
            try
            {
                var testsQuery = _testsRepository.AsQueryable()
                    .Where(e => e.PatientID == request.PatientID);

                if (request.PerformedOnFrom is not null)
                {
                    testsQuery = testsQuery.Where(e => e.PerformedOn >= request.PerformedOnFrom);
                }

                if (request.PerformedOnToExcluded is not null)
                {
                    testsQuery = testsQuery.Where(e => e.PerformedOn < request.PerformedOnToExcluded);
                }

                testsQuery = testsQuery.OrderBy(e => e.PerformedOn);

                var testList = await testsQuery.ToListAsync();

                var testDtoList = new List<TestDto>(testList.Count);

                foreach (var test in testList)
                {
                    var testDto = new TestDto()
                    {
                        ID = test.ID,
                        PatientID = test.PatientID,
                        Name = test.Name,
                        PerformedOn = test.PerformedOn,
                        Result = test.Result,
                        IsWithinThreshold = test.IsWithinThreshold,
                        UpdatedAt = test.UpdatedAt
                    };

                    testDtoList.Add(testDto);
                }

                return Result<List<TestDto>>.Ok(testDtoList);
            }
            catch (Exception ex)
            {
                // logging
                return Result<List<TestDto>>.Fail("Fetching tests info failed");
            }
            finally
            {
                _unitOfWork.ClearTracker();
            }
        }

        public async Task<Result<TestDto>> UpdateAsync(UpdateTestRequest request)
        {
            try
            {
                var test = await _testsRepository.GetAsync(request.ID);

                if (test is null)
                {
                    return Result<TestDto>.Fail("Updating test failed. Test can not be found");
                }

                test.Name = request.Name;
                test.PerformedOn = request.PerformedOn;
                test.Result = request.Result;
                test.IsWithinThreshold = request.IsWithinThreshold;
                test.UpdatedAt = DateTime.Now;

                _testsRepository.Update(test);
                await _unitOfWork.SaveChangesAsync(CancellationToken.None);

                var testDto = new TestDto()
                {
                    ID = test.ID,
                    PatientID = test.PatientID,
                    Name = test.Name,
                    PerformedOn = test.PerformedOn,
                    Result = test.Result,
                    IsWithinThreshold = test.IsWithinThreshold,
                    UpdatedAt = test.UpdatedAt
                };

                return Result<TestDto>.Ok(testDto);
            }
            catch (Exception ex)
            {
                // logging
                return Result<TestDto>.Fail("Updating test failed");
            }
            finally
            {
                _unitOfWork.ClearTracker();
            }
        }
    }
}
