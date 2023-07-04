using MediatR;

namespace Employee_Web_Application.Features.Commands
{
    public class UpdateEmployeeCommand : IRequest<bool>
    {
        public UpdateEmployeeCommand(int emp_Id, string name, string email, string password, string salary)
        {
            Emp_Id = emp_Id;
            Name = name;
            Email = email;
            Password = password;
            Salary = salary;
        }

        public int Emp_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salary { get; set; }
    }
}
