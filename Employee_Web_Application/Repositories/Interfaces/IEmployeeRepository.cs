using Employee_Web_Application.Models;

namespace Employee_Web_Application.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployee();
        public Task<Employee> GetEmployeeById(int id);
        public Task<Employee> GetEmployeeByName(string name);
        public Task<bool> AddEmployee(Employee employee);
        public Task<bool> UpdateEmployee(Employee employee);
        public Task<bool> DeleteEmployee(int id);
    }
}
