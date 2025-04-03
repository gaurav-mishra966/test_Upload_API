using Aeries_Student_WebApi.Data;
using Aeries_Student_WebApi.Models.Domain;
using Aeries_Student_WebApi.Models.DTO;

namespace Aeries_Student_WebApi.Repositories.Interface
{
    public interface INoDBMedicalRepository
    {
        List<WithoutDB_MedicalRecord> GetMedicalRecords();

    }
}
