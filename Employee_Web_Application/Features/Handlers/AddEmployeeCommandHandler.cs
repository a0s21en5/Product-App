using Employee_Web_Application.Features.Commands;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repositories.Interfaces;
using MediatR;

namespace Employee_Web_Application.Features.Handlers
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public AddEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<bool> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee employee = new Employee
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                Salary = request.Salary,
            };
            return await _employeeRepository.AddEmployee(employee);
        }
    }
}
