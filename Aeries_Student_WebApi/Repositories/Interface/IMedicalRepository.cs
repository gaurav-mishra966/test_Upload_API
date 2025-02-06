using Aeries_Student_WebApi.Models.Domain;

namespace Aeries_Student_WebApi.Repositories.Interface
{
    public interface IMedicalRepository
    {
        Task<Medical> GetMedicalRecordByStudentIdAsync(int id);

        Task<Medical> CreateMedicalRecordByStudentId(Medical medical,int id);


    }
}
