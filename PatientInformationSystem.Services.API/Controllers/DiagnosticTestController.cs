using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PatientInformationSystem.Services.Core.Manager.Interfaces;
using PatientInformationSystem.Services.Entities.HospitalManagement;
namespace PatientInformationSystem.Services.API.Controllers
{

    public class DiagnosticTestController : ApiController
    {
        private readonly IDiagnosticTestManager _iDiagnosticTestManager;

        public DiagnosticTestController(IDiagnosticTestManager iDiagnosticTestManager)
        {
            _iDiagnosticTestManager = iDiagnosticTestManager;
        }

        public List<DiagnosticTest> GetDiagnosticTests()
        {

            var tests = new List<DiagnosticTest>();
            return tests;
        }

    }
}
