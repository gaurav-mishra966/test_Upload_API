using Aeries_Student_WebApi.Models.DTO;
using Aeries_Student_WebApi.Repositories.Interface;
using Aeries_Student_WebApi.Services.Interfaces;
using Aeries_Student_WebApi.Models.Domain;
using System.Threading.Tasks;

namespace Aeries_Student_WebApi.Services.Implementations
{
    public class MedicalService : IMedicalService
    {
        private readonly INoDBMedicalRepository noDbMedicalRepository;
        private readonly IMedicalRepository medicalRepository;

        public MedicalService(INoDBMedicalRepository noDbMedicalRepository, IMedicalRepository medicalRepository)
        {
            this.noDbMedicalRepository = noDbMedicalRepository;
            this.medicalRepository = medicalRepository;
        }

        public List<WithoutDB_MedicalRecord> GetMedicalRecords()
        {
            return noDbMedicalRepository.GetMedicalRecords();
        }

        public List<WithoutDB_MedicalRecord> GetMedicalRecordByStudentId(int id)
        {
            var medicalRecords = noDbMedicalRepository.GetMedicalRecords();
            var result = medicalRecords.Where(x => x.StudentId == id).ToList();
            return result;
        }

        public async Task<Medical> GetMedicalRecordByStudentIdAsync(int id)
        {
            return await medicalRepository.GetMedicalRecordByStudentIdAsync(id);
        }

        public async Task<Medical> CreateMedicalRecordByStudentIdAsync(Medical medical, int id)
        {
            return await medicalRepository.CreateMedicalRecordByStudentId(medical, id);
        }
    }
}
