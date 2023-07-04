using Employee_Web_Application.Models;
using MediatR;

namespace Employee_Web_Application.Features.Queries
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int Emp_Id { get; set; }
    }
}
