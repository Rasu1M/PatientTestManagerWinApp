namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Request
{
    public class UpdateTestRequest
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime PerformedOn { get; set; }
        public decimal Result { get; set; }
        public bool IsWithinThreshold { get; set; }
    }
}
