using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientInformationSystem.Services.API.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}