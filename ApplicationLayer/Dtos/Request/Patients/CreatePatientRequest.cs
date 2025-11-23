namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Patients
{
    public class CreatePatientRequest
    {
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
    }
}
