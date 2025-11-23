using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Basic;

namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Tests
{
    public class GetTestsRequest : BasePaginationRequest
    {
        public int PatientID { get; set; }
        public DateTime? PerformedOnFrom { get; set; }
        public DateTime? PerformedOnTo { get; set; }
    }
}
