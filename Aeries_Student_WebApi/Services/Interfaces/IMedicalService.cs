using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeries_Student_WebApi.Models.Domain;
using Aeries_Student_WebApi.Models.DTO;
using Aeries_Student_WebApi.Repositories.Implementation;

namespace Aeries_Student_WebApi.Services.Interfaces
{
    public interface IMedicalService
    {
        List<WithoutDB_MedicalRecord> GetMedicalRecords();
        List<WithoutDB_MedicalRecord> GetMedicalRecordByStudentId(int id);
        Task<Medical> GetMedicalRecordByStudentIdAsync(int id);
        Task<Medical> CreateMedicalRecordByStudentIdAsync(Medical medical, int id);
    }
}
