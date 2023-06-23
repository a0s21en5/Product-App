using Dapper;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repository.Interface;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Web_Application.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly string _connectionString;
        public EmployeesRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        //Get All Employees
        public async Task<List<Employees>> GetAllEmployees()
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                string sQuery = "EXEC sp_GetEmployees";
                List<Employees> AllEmployees = (await dbConnection.QueryAsync<Employees>(sQuery)).ToList();
                dbConnection.Close(); 
                return AllEmployees;
            }
        }

        //Get Employees By Name
        public async Task<Employees> GetEmployeesByName(string employeeName)
        {
            using(IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                string sQuery = "EXEC sp_GetEmployeesByName EmployeeName = @EmployeeName";
                Employees AllEmployees = (await dbConnection.QuerySingleOrDefaultAsync(sQuery)).ToList();
                dbConnection.Close();
                return AllEmployees;
            }
        }

        public Task<bool> InsertEmployees(Employees employees)
        {
            throw new NotImplementedException();
        }
    }
}
