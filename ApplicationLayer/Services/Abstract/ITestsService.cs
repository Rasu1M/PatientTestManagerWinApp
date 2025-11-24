using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Tests;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Tests;
using PatientTestManagerWinApp.ApplicationLayer.Models;

namespace PatientTestManagerWinApp.ApplicationLayer.Services.Abstract
{
    public interface ITestsService
    {
        public Task<Result<List<TestDto>>> GetAsync(GetTestsRequest request);
        public Task<Result<TestDto>> CreateAsync(CreateTestRequest request);
        public Task<Result<TestDto>> UpdateAsync(UpdateTestRequest request);
        public Task<Result<bool>> DeleteAsync(int id);
    }
}
