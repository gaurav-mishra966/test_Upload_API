namespace Aeries_Student_WebApi.Models.Domain
{
    public class BillingCode
    {
        public Dictionary<string, List<int>>? Prop1 { get; set; }
        public Dictionary<string, List<string>>? Units { get; set; }
    }

    //// ResultType Enum for predefined result types
    //public enum ResultType
    //{
    //    HO,  // Hospitalization
    //    PA,  // Paramedics Called
    //    RC,  // Returned to Class
    //    RP   // Released to Parents
    //}

    //// UnitType Enum for predefined unit types
    //public enum UnitType
    //{
    //    ADM,  // Administrator
    //    HCL,  // Health Clerk
    //    NUR   // Nurse
    //}
    public class Medical
    {
        public int? studentID { get; set; }
        public string? medicalRecordId { get; set; }
        //public DateTime? medicalDate { get; set; }
        public string? medicalDate { get; set; }
        //public List<int>? medicalCode { get; set; }
        public string? medicalCode { get; set; }
        //public TimeSpan? medicalST { get; set; }
        public string? medicalST { get; set; }
        //public TimeSpan? medicalET { get; set; }
        public string? medicalET { get; set; }
        //public DateTime? medicalSD { get; set; }
        public string? medicalSD { get; set; }
        //public DateTime? medicalED { get; set; }
        public string? medicalED { get; set; }
        //public List<string>? medicalBC { get; set; }
        public string? medicalBC { get; set; }
        //public List<string>? medicalBU { get; set; }
        public string? medicalBU { get; set; }
        //public List<string>? medicalIN { get; set; }
        public string? medicalIN { get; set; }
        public string? Tag { get; set; }
        public string? medicalCO { get; set; }

        //public List<string>? medicalBillC { get; set; }
        public string? medicalBillC { get; set; }
        //public BillingCode? BillingCode { get; set; }
        public string? BillingCode { get; set; }
    }
}
