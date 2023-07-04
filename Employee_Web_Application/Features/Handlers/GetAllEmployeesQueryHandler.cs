using Employee_Web_Application.Features.Queries;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repositories.Interfaces;
using MediatR;

namespace Employee_Web_Application.Features.Handlers
{
    public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetAllEmployeesQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetAllEmployee();
        }
    }
}
