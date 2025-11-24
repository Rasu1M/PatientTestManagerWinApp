namespace PatientTestManagerWinApp.Domain.Entities
{
    public class Test : BaseEntity
    {
        public int PatientID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime PerformedOn { get; set; }
        public decimal Result { get; set; }
        public bool IsWithinThreshold { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Patient? Patient { get; set; }
    }
}
