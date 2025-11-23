namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Patients
{
    public class UpdatePatientRequest
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
    }
}
