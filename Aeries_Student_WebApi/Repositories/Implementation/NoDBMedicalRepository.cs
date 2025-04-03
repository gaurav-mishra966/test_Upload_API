using Aeries_Student_WebApi.Data;
using Aeries_Student_WebApi.Models.Domain;
using Aeries_Student_WebApi.Models.DTO;
using Aeries_Student_WebApi.Repositories.Interface;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace Aeries_Student_WebApi.Repositories.Implementation
{
    public class NoDBMedicalRepository:INoDBMedicalRepository
    {
        private readonly ApplicationDbContext dbContext;

        public NoDBMedicalRepository(ApplicationDbContext applicationDb)
        {
            this.dbContext = applicationDb;
        }

        public List<WithoutDB_MedicalRecord> GetMedicalRecords()
        {
            try
            {
                return MedicalDatasetHelper.GetMedicalRecords();
            }
            catch (Exception ex)
            {
                // Handle any connection or query errors
                throw new Exception($"Error retrieving medical records: {ex.Message}", ex);
            }

        }
    }
}
