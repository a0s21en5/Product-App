# Employee Web Application
- About ASP.NET 6 Core CRUD Operations Using SQL Stored Procedure, CQRS & Dapper

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class EmployeeRepository
{
    private readonly string _connectionString;

    public EmployeeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<int> InsertAsync(Employee employee)
    {
        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var query = "INSERT INTO Employees (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password); SELECT CAST(SCOPE_IDENTITY() as int);";
        return await connection.ExecuteScalarAsync<int>(query, employee);
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var query = "SELECT * FROM Employees WHERE Id = @Id;";
        return await connection.QueryFirstOrDefaultAsync<Employee>(query, new { Id = id });
    }

    public async Task UpdateAsync(Employee employee)
    {
        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password WHERE Id = @Id;";
        await connection.ExecuteAsync(query, employee);
    }

    public async Task DeleteAsync(int id)
    {
        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var query = "DELETE FROM Employees WHERE Id = @Id;";
        await connection.ExecuteAsync(query, new { Id = id });
    }

    public async Task<Employee> GetByEmailAndPasswordAsync(string email, string password)
    {
        using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        var query = "SELECT * FROM Employees WHERE Email = @Email AND Password = @Password;";
        return await connection.QueryFirstOrDefaultAsync<Employee>(query, new { Email = email, Password = password });
    }
}

public class EmployeeController : ControllerBase
{
    private readonly EmployeeRepository _employeeRepository;

    public EmployeeController(EmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Employee employee)
    {
        var id = await _employeeRepository.InsertAsync(employee);
        return Ok(id);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var employee = await _employeeRepository.GetByIdAsync(id);
        if (employee == null)
            return NotFound();

        return Ok(employee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Employee employee)
    {
        employee.Id = id;
        await _employeeRepository.UpdateAsync(employee);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _employeeRepository.DeleteAsync(id);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
        var employee = await _employeeRepository.GetByEmailAndPasswordAsync(loginModel.Email, loginModel.Password);
        if (employee == null)
            return Unauthorized();

        return Ok(employee);
    }
}
