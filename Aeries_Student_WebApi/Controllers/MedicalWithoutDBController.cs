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
        public ActionResult<WithoutDB_MedicalRecord> GetMedicalRecord([FromRoute] int id)
{
    try
    {
        // Static data for medical records based on the updated DB-model
        var medicalRecords_DBLess = new List<WithoutDB_MedicalRecord>
        {
            new WithoutDB_MedicalRecord
            {
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
                BillingCode = "BC002",
                Units = "1",
                Initials = "CD",
                Comments = "Rest for 3 days"
            },
            new WithoutDB_MedicalRecord
            {
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
                BillingCode = "BC003",
                Units = "2",
                Initials = "EF",
                Comments = "Lab results pending"
            }
        };

        // Find the medical record(s) based on the passed id (using MedicalRecordId in this case)
        var studentMedicalRecords = medicalRecords_DBLess.Where(m => m.MedicalRecordId.Contains(id.ToString())).ToList();

        // Check if the medical record(s) were found
        if (studentMedicalRecords.Count == 0)
        {
            return NotFound($"Medical record for ID {id} not found.");
        }

        // Construct MedicalWithoutDBDto and return
        var result = new MedicalWithoutDBDto
        {
            StudentId = id,
            WithoutDB_MedicalRecords = studentMedicalRecords
        };

        return Ok(result);
    }
    catch (Exception ex)
    {
        // Return a BadRequest if an error occurs
        return BadRequest(ex.Message);
    }
}
    }
}
