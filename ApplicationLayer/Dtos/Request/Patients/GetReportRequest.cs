using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Patients
{
    public class GetReportRequest
    {
        public DateTime? PerformedOnFrom { get; set; }
        public DateTime? PerformedOnToExcluded { get; set; }
    }
}
