using Services.Interfaces;

namespace Services.Implementations
{
    public class MedicalService : IMedicalService
    {

        private readonly INoDBMedicalRepository noDbMedicalRepository;

        public MedicalService(INoDBMedicalRepository noDbMedicalRepository)
        {
            this.noDbMedicalRepository = noDbMedicalRepository;
        }
        public List<WithoutDB_MedicalRecord> GetMedicalRecords()
        {
            return noDbMedicalRepository.GetMedicalRecords();
        }
        public List<WithoutDB_MedicalRecord> GetMedicalRecordByStudentId(int id)
        {
            var medicalRecords = noDbMedicalRepository.GetMedicalRecords();
            var result = medicalRecords.FirstOrDefault(x => string.IsNullOrWhiteSpace(x.MedicalRecordId) && x.MedicalRecordId == id.ToString());
        }
    }
}
