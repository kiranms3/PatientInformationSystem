using System;
using System.Collections.Generic;
using PatientInformationSystem.Services.Data.Repository.Interfaces;
using PatientInformationSystem.Services.Entities.HospitalManagement;
using PatientInformationSystem.Services.Core.Manager.Interfaces;

namespace PatientInformationSystem.Services.Core.Manager.Implementation
{

    public class DiagnosticTestManager : IDiagnosticTestManager
    {
        private readonly IDiagnosticTestRepository _iDiagnosticTestRepository;
        public DiagnosticTestManager(IDiagnosticTestRepository iDiagnosticTestRepository)
        {
            _iDiagnosticTestRepository = iDiagnosticTestRepository;
        }
        public List<DiagnosticTest> GetAllDiagnosticTests()
        {
            return _iDiagnosticTestRepository.GetAllDiagnosticTests();
        }
    }
}
