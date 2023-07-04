using Employee_Web_Application.Features.Queries;
using Employee_Web_Application.Models;
using Employee_Web_Application.Repositories.Interfaces;
using MediatR;

namespace Employee_Web_Application.Features.Handlers
{
    public class GetEmployeesByNameQueryHandler : IRequestHandler<GetEmployeesByNameQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeesByNameQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(GetEmployeesByNameQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeByName(request.Name);
        }
    }
}
