using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientInformationSystem.Services.Entities.HospitalManagement;
namespace PatientInformationSystem.Services.Data.Repository.Interfaces
{

    public interface IDiagnosticTestRepository
    {
        List<DiagnosticTest> GetAllDiagnosticTests();
    }
}
