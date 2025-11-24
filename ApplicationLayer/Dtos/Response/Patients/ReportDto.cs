namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Patients
{
    public class ReportDto
    {
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int TestCount { get; set; }
        public string? TestsWithinThresholdPercentage { get; set; }
    }
}
