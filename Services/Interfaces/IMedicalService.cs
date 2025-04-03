using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services.Interfaces
{
    internal interface IMedicalService
    {
        List<WithoutDB_MedicalRecord> GetMedicalRecords();
        List<WithoutDB_MedicalRecord> GetMedicalRecordByStudentId(int id);
    }
}
