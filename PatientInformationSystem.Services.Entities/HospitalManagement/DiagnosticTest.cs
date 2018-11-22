using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Services.Entities.HospitalManagement
{
    public class DiagnosticTest
    {
        public int TestId { get; set; }

        public string TestName { get; set; }

        public decimal Fees { get; set; }
    }
}
