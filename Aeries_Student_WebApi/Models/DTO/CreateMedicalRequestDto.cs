using Aeries_Student_WebApi.Models.Domain;

namespace Aeries_Student_WebApi.Models.DTO
{
    public class CreateMedicalRequestDto
    {
        public int? StudentId { get; set; }
        public int? MedicalRecordId { get; set; }
        public DateTime? Date { get; set; }
        //public List<int>? Code { get; set; }
        public string? Code { get; set; }
        //public TimeSpan? StartTime { get; set; }
        public string? StartTime { get; set; }
        //public TimeSpan? EndTime { get; set; }
        //public string? EndTime { get; set; }
        public string? EndTime { get; set; }
        //public DateTime? StartDate { get; set; }
        public string? StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
        public string? EndDate { get; set; }
        //public List<string>? Result { get; set; }
        public string? Result { get; set; }
        public string? Tag { get; set; }
        public string? Remarks { get; set; }
        public BillingCode? BillingCode { get; set; }
    }
}
