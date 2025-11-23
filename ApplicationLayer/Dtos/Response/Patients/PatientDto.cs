using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Patients
{
    public class PatientDto
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
    }
}
