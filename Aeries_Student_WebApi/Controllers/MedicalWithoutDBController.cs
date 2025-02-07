using Aeries_Student_WebApi.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeries_Student_WebApi.Controllers
{
    
    [ApiController]
    [Route("MedicalWithoutDB")]
    public class MedicalWithoutDBController : ControllerBase
    {
        //Static Data Implementation Method
        [HttpGet]
        [Route("getMedicalRecord")]
        public IEnumerable<MedicalDto> GetMedicalRecord()
        {
            try
            {
                // Static data for medical records based on the DB-model
                var medicalRecords = new List<MedicalDto>
                {
                    new MedicalDto
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
                        BillingCode = "SomeString"
                        //new BillingCode { Code = "B123", Description = "General Consultation" }
                    },
                    new MedicalDto
                    {
                        StudentId = 2,
                        MedicalRecordId = "MR12346",
                        Date = "2025-02-02",
                        Code = "B456",
                        StartTime = "10:00",
                        EndTime = "11:00",
                        StartDate = "2025-02-02",
                        EndDate = "2025-02-02",
                        Result = "Negative",
                        Tag = "Emergency Visit",
                        Remarks = "Minor injury, advised rest",
                        BillingCode = "SomeString"
                        //BillingCode = new BillingCode { Code = "B456", Description = "Emergency Visit" }
                    },
                    new MedicalDto
                    {
                        StudentId = 3,
                        MedicalRecordId = "MR12347",
                        Date = "2025-02-03",
                        Code = "C789",
                        StartTime = "14:00",
                        EndTime = "15:00",
                        StartDate = "2025-02-03",
                        EndDate = "2025-02-03",
                        Result = "Pending",
                        Tag = "Follow-up",
                        Remarks = "Awaiting lab results",
                        BillingCode = "SomeString"
                        //BillingCode = new BillingCode { Code = "C789", Description = "Follow-up Consultation" }
                    }
                };

                return medicalRecords;
            }
            catch (Exception ex)
            {
                // Assuming BadRequest is a method that returns an error response
                return (IEnumerable<MedicalDto>)BadRequest(ex.Message);
            }
        }
    }
}
