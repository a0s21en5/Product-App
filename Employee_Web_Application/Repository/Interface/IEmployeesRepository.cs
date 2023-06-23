using Employee_Web_Application.Models;

namespace Employee_Web_Application.Repository.Interface
{
    public interface IEmployeesRepository
    {
        Task<List<Employees>> GetAllEmployees();
        Task<Employees> GetEmployeesByName(string employeeName);
        Task<bool> InsertEmployees(Employees employees);
    }
}
