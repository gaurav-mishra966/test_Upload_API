using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeries_Student_WebApi.Models.DTO;

namespace Aeries_Student_Services.Interface
{
    public interface IMedicalService
    {
        List<WithoutDB_MedicalRecord> GetMedicalRecords();
        WithoutDB_MedicalRecord GetMedicalRecordByStudentId(int id);
    }
}
