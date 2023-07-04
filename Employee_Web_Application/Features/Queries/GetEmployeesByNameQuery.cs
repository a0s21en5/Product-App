using Employee_Web_Application.Models;
using MediatR;

namespace Employee_Web_Application.Features.Queries
{
    public class GetEmployeesByNameQuery : IRequest<Employee>
    {
        public string Name { get; set; }
    }
}
