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

        public List<WithoutDB_MedicalRecord> GetMedicalRecords()
        {
            return MedicalDatasetHelper.GetMedicalRecords();
        }
    }
}
