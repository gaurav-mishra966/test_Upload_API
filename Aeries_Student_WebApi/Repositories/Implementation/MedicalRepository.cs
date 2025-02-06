using Aeries_Student_WebApi.Data;
using Aeries_Student_WebApi.Models.Domain;
using Aeries_Student_WebApi.Repositories.Interface;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace Aeries_Student_WebApi.Repositories.Implementation
{
    public class MedicalRepository:IMedicalRepository
    {
        private readonly ApplicationDbContext dbContext;

        public MedicalRepository(ApplicationDbContext applicationDb)
        {
            this.dbContext = applicationDb;
        }


        //Connection checking
        // Check if the connection is open
        public bool IsConnectionOpen()
        {
            return dbContext.Database.GetDbConnection().State == System.Data.ConnectionState.Open;
        }


        // Close the connection
        public async Task CloseConnectionAsync()
        {
            var connection = dbContext.Database.GetDbConnection();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }


        // Open the connection
        public async Task OpenConnectionAsync()
        {
            var connection = dbContext.Database.GetDbConnection();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                await connection.OpenAsync();
            }
        }


        public async Task<Medical> GetMedicalRecordByStudentIdAsync(int id)
        {
            try
            {
                await OpenConnectionAsync();
                var studentMedicalRecord = await dbContext.MedicalData.FirstOrDefaultAsync(c => c.studentID == id);
                return studentMedicalRecord;
            }
            catch (Exception ex)
            {
                // Handle any connection or query errors
                throw new Exception($"Error retrieving medical record for student with ID {id}: {ex.Message}", ex);
            }

        }


        public async Task<Medical> CreateMedicalRecordByStudentId(Medical medical,int id)
        {
            await dbContext.MedicalData.AddAsync(medical);
            await dbContext.SaveChangesAsync();

            return medical;
        }
    }
}
