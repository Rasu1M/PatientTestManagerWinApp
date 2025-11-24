using PatientTestManagerWinApp.Domain.Enums;

namespace PatientTestManagerWinApp.Domain.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Test>? Tests { get; set; }
    }
}
