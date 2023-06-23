using Employee_Web_Application.Models;
using Employee_Web_Application.Repository.Interface;
using Employee_Web_Application.Service.Interface;

namespace Employee_Web_Application.Service
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        //Get All Employees
        public async Task<List<Employees>> GetAllEmployees()
        {
            return await _employeesRepository.GetAllEmployees();
        }

        //Insert Employees
        public async Task<bool> InsertEmployees(Employees employees)
        {
            Employees InsertEmployeesExistStatus = await _employeesRepository.GetEmployeesByName(employees.EmployeeName);
            if(InsertEmployeesExistStatus == null)
            {
                return await _employeesRepository.InsertEmployees(employees);
            }
            return true;
        }
    }
}
