using Aeries_Student_WebApi.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aeries_Student_WebApi.Controllers
{
    [ApiController]
    [Route("MedicalWithoutDB")]
    public class MedicalWithoutDBController : ControllerBase
    {
        // Static Data Implementation Method
        [HttpGet]
        [Route("getMedicalRecord/{id:int}")]
        public ActionResult<MedicalDto> GetMedicalRecord([FromRoute] int id)
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
                        Remarks = "No further issues"
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
                        Remarks = "Minor injury, advised rest"
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
                        Remarks = "Awaiting lab results"
                    }
                };

                // Find the medical record based on the passed id (StudentId or MedicalRecordId)
                var medicalRecord = medicalRecords.FirstOrDefault(m => m.StudentId == id); // You can change this to match `MedicalRecordId` if needed

                // Check if the medical record was found
                if (medicalRecord == null)
                {
                    return NotFound($"Medical record for Student ID {id} not found.");
                }

                // Return the found medical record
                return Ok(medicalRecord);
            }
            catch (Exception ex)
            {
                // Return a BadRequest if an error occurs
                return BadRequest(ex.Message);
            }
        }
    }
}
