using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Services.Entities.HospitalManagement
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
