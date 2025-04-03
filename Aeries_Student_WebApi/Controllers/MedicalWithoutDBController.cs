using Aeries_Student_WebApi.Data;
using Aeries_Student_WebApi.Models.DTO;
using Aeries_Student_WebApi.Repositories.Interface;
using Aeries_Student_WebApi.Services.Interfaces;
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
        private readonly IMedicalService medicalService;

        public MedicalWithoutDBController(IMedicalService medicalService)
        {
            this.medicalService = medicalService;
        }

        // Static Data Implementation Method
        [HttpGet]
        [Route("getMedicalRecord/{id:int}")]
        public ActionResult<WithoutDB_MedicalRecord> GetMedicalRecord([FromRoute] int id)
        {
            try
            {
                var studentMedicalRecords = medicalService.GetMedicalRecordByStudentId(id);
                // Check if the medical record(s) were found
                if (studentMedicalRecords == null)
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
