namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Tests
{
    public class GetTestsRequest
    {
        public int PatientID { get; set; }
        public DateTime? PerformedOnFrom { get; set; }
        public DateTime? PerformedOnToExcluded { get; set; }
    }
}
