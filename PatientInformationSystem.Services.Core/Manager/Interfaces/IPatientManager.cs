using PatientInformationSystem.Services.Entities.HospitalManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Services.Core.Manager.Interfaces
{

    public interface IPatientManager
    {
        List<Patient> GetAllPatients();
    }
}
