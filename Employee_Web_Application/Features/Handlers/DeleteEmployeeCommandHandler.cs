using Employee_Web_Application.Features.Commands;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repositories.Interfaces;
using MediatR;

namespace Employee_Web_Application.Features.Handlers
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee employee = await _employeeRepository.GetEmployeeById(request.Emp_Id);
            if (employee == null)
            {
                return default;
            }

            return await _employeeRepository.DeleteEmployee(request.Emp_Id);
        }
    }
}





