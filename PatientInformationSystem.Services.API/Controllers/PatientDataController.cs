using System.Web.Http;
using System;
using PatientInformationSystem.Services.API.Models;
using System.Collections.Generic;
using PatientInformationSystem.Services.Core.Manager.Interfaces;
namespace PatientInformationSystem.Services.API.Controllers
{
    public class PatientDataController : ApiController
    {
        private readonly IPatientManager _iPatientManager;

        public PatientDataController(IPatientManager iPatientManager)
        {
            _iPatientManager = iPatientManager;
        }

        public List<Patient> GetPatients()
        {

            var patients = new List<Patient>();
            return patients;
        }
    }
}
