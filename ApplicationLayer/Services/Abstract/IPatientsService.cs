using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Models;

namespace PatientTestManagerWinApp.ApplicationLayer.Services.Abstract
{
    public interface IPatientsService
    {
        public Task<Result<List<PatientDto>>> GetAsync(GetPatientsRequest request);
        public Task<Result<PatientDto>> CreateAsync(CreatePatientRequest request);
        public Task<Result<PatientDto>> UpdateAsync(UpdatePatientRequest request);
        public Task<Result<bool>> DeleteAsync(int id);
        public Task<Result<List<ReportDto>>> GetReport(GetReportRequest request);
    }
}
