using Employee_Web_Application.Models;

namespace Employee_Web_Application.Service.Interface
{
    public interface IEmployeesService
    {
        Task<List<Employees>> GetAllEmployees();
        Task<bool> InsertEmployees(Employees employees);
    }
}
