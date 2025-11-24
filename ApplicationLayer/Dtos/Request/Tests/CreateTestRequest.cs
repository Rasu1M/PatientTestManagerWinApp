namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Tests
{
    public class CreateTestRequest
    {
        public int PatientID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime PerformedOn { get; set; }
        public decimal Result { get; set; }
        public bool IsWithinThreshold { get; set; }
    }
}
