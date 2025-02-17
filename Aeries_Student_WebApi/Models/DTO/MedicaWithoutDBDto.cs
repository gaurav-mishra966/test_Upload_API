namespace Aeries_Student_WebApi.Models.DTO
{

    public class MedicalWithoutDBDto
    {
        public int StudentId { get; set; }
        public List<WithoutDB_MedicalRecord>? WithoutDB_MedicalRecords { get; set; }
    }
    public class WithoutDB_MedicalRecord
    {
        public string? MedicalRecordId { get; set; }
        public string? Date { get; set; }
        public string? Code { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? Result { get; set; }
        public string? Tag { get; set; }
        public string? Remarks { get; set; }
        public string? BillingCode { get; set; }
        public string? Units { get; set; }
        public string? Initials { get; set; }
        public string? Comments { get; set; }
    }
}
