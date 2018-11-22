using System;
using System.Collections.Generic;
using PatientInformationSystem.Services.Core.Manager.Interfaces;
using PatientInformationSystem.Services.Entities.HospitalManagement;
using PatientInformationSystem.Services.Data.Repository.Interfaces;
namespace PatientInformationSystem.Services.Core.Manager.Implementation
{

    public class PatientManager : IPatientManager
    {
        private readonly IPatientRepository _iPatientRepository;
        public PatientManager(IPatientRepository iPatientRepository)
        {
            _iPatientRepository = iPatientRepository;
        }
        public List<Patient> GetAllPatients()
        {
            return _iPatientRepository.GetAllPatients();
        }
    }
}
