using System.Reflection.Metadata.Ecma335;
using Aeries_Student_WebApi.Models.DTO;

namespace Aeries_Student_WebApi.Data
{
    public class MedicalDatasetHelper
    {
        public static List<WithoutDB_MedicalRecord> GetMedicalRecords()
        {
            var medicalRecords_DBLess = new List<WithoutDB_MedicalRecord>
            {
                new WithoutDB_MedicalRecord
                {
                    StudentId = 1,
                    MedicalRecordId = "MR12345",
                    Date = "2025-02-01",
                    Code = "A123",
                    StartTime = "08:00",
                    EndTime = "09:00",
                    StartDate = "2025-02-01",
                    EndDate = "2025-02-01",
                    Result = "Positive",
                    Tag = "Routine Check",
                    Remarks = "No further issues",
                    BillingCode = "BC001",
                    Units = "1",
                    Initials = "AB",
                    Comments = "Follow-up required"
                },
                new WithoutDB_MedicalRecord
                {
                    StudentId = 1,
                    MedicalRecordId = "MR12346",
                    Date = "2025-02-10",
                    Code = "D321",
                    StartTime = "11:00",
                    EndTime = "12:00",
                    StartDate = "2025-02-10",
                    EndDate = "2025-02-10",
                    Result = "Negative",
                    Tag = "Vaccination",
                    Remarks = "Routine vaccination",
                    BillingCode = "BC004",
                    Units = "1",
                    Initials = "GH",
                    Comments = "Next dose in 6 months"
                },
                new WithoutDB_MedicalRecord
                {
                    StudentId = 2,
                    MedicalRecordId = "MR12347",
                    Date = "2025-02-02",
                    Code = "B456",
                    StartTime = "10:00",
                    EndTime = "11:00",
                    StartDate = "2025-02-02",
                    EndDate = "2025-02-02",
                    Result = "Negative",
                    Tag = "Emergency Visit",
                    Remarks = "Minor injury, advised rest",
                    BillingCode = "BC002",
                    Units = "1",
                    Initials = "CD",
                    Comments = "Rest for 3 days"
                },
                new WithoutDB_MedicalRecord
                {
                    StudentId = 2,
                    MedicalRecordId = "MR12348",
                    Date = "2025-02-15",
                    Code = "E654",
                    StartTime = "09:00",
                    EndTime = "10:00",
                    StartDate = "2025-02-15",
                    EndDate = "2025-02-15",
                    Result = "Pending",
                    Tag = "Lab Test",
                    Remarks = "Blood test pending",
                    BillingCode = "BC005",
                    Units = "2",
                    Initials = "IJ",
                    Comments = "Report expected in 2 days"
                },
                new WithoutDB_MedicalRecord
                {
                    StudentId = 3,
                    MedicalRecordId = "MR12349",
                    Date = "2025-02-03",
                    Code = "C789",
                    StartTime = "14:00",
                    EndTime = "15:00",
                    StartDate = "2025-02-03",
                    EndDate = "2025-02-03",
                    Result = "Pending",
                    Tag = "Follow-up",
                    Remarks = "Awaiting lab results",
                    BillingCode = "BC003",
                    Units = "2",
                    Initials = "EF",
                    Comments = "Lab results pending"
                },
                new WithoutDB_MedicalRecord
                {
                    StudentId = 3,
                    MedicalRecordId = "MR12350",
                    Date = "2025-02-20",
                    Code = "F987",
                    StartTime = "13:00",
                    EndTime = "14:00",
                    StartDate = "2025-02-20",
                    EndDate = "2025-02-20",
                    Result = "Positive",
                    Tag = "Routine Check",
                    Remarks = "Mild fever, under observation",
                    BillingCode = "BC006",
                    Units = "1",
                    Initials = "KL",
                    Comments = "Re-evaluate after 48 hours"
                }
            };
            return medicalRecords_DBLess;
        }
    }
}