using Aeries_Student_WebApi.Models.Domain;
using Aeries_Student_WebApi.Models.DTO;
using Aeries_Student_WebApi.Repositories.Implementation;
using Aeries_Student_WebApi.Repositories.Interface;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeries_Student_WebApi.Controllers
{

    [ApiController]
    [Route("Medical")]  // Remove [controller] here, route should just be Medical
    public class MedicalController : ControllerBase
    {
        private readonly IMedicalRepository medicalRepository;

        public MedicalController(IMedicalRepository medicalRepository)
        {
            this.medicalRepository = medicalRepository;
        }


        [HttpGet]
        [Route("getMedicalRecordByStudentID/{id:int}")]
        // [Authorize(Roles = "Reader")] 
        public async Task<IActionResult> GetStudentMedicalRecordById([FromRoute] int id)
        {
            try
            {
                // Fetch the medical record by student ID
                var medicalData = await medicalRepository.GetMedicalRecordByStudentIdAsync(id);

                // If no medical data is found, return a NotFound response
                if (medicalData == null)
                {
                    return NotFound(new { Message = $"No Medical record for student with ID {id} not found." });
                }

                // Map the data to a DTO if needed (e.g., MedicalDto)
                var medicalDto = new MedicalDto
                {
                    // Assuming you have a DTO to map the necessary properties
                    StudentId = medicalData.studentID,  // Ensure this matches your medicalData model
                    MedicalRecordId = medicalData.medicalRecordId,  // Adjust according to your data model
                    Date = medicalData.medicalSD,
                    Code = medicalData.medicalCode,
                    StartTime = medicalData.medicalST,
                    EndTime = medicalData.medicalET,
                    StartDate = medicalData.medicalSD,
                    EndDate = medicalData.medicalED,
                    Tag = medicalData.Tag,
                    Remarks = medicalData.medicalCO

                };

                // Return the medical record data with a 200 OK response
                return Ok(medicalDto);
            }
            catch (Exception ex)
            {
                //return BadRequest();
                return StatusCode(500, new { Message = $"An error occurred: {ex.Message}" });
                
            }
            finally
            {

            }
        }

        [HttpPost]
        [Route("createMedicalRecordByStudentID/{id:int}")]
        public async Task<IActionResult> CreateStudentMedicalRecordByID([FromBody]CreateMedicalRequestDto request, [FromRoute] int id)
        {
            //if (medicalRepository.IsConnectionOpen())
            //{
            //    await medicalRepository.CloseConnectionAsync(); // Close the connection if it's open
            //}

            try
            {
                //map dto to domain model
                var medical = new Medical
                {
                    //adding fields where insertion to be performed
                    studentID = id,
                    //medicalRecordId = request.MedicalRecordId,
                    //medicalDate = DateTime.UtcNow,
                    //medicalCode=request.Code,
                    //medicalST=request.StartTime,
                    //medicalET = request.EndTime,
                    //medicalSD = request.StartDate,
                    //medicalED =request.EndDate,
                    Tag = request.Tag,
                };

                await medicalRepository.CreateMedicalRecordByStudentId(medical, id);

                //map this to domain model to dto
                var response = new MedicalDto
                {
                    StudentId = medical.studentID,
                    MedicalRecordId = medical.medicalRecordId,
                    Date=medical.medicalDate,
                    Code=medical.medicalCode,
                    StartTime = medical.medicalST,
                    EndTime = medical.medicalET,
                    StartDate = medical.medicalSD,                    
                    EndDate = medical.medicalED,                    
                    Tag=medical.Tag,
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = $"An error occurred While Record Creation: {ex.Message}" });
            }
        }
    }
}