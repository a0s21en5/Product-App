-- Create Stored Procedure - Create a new employee record
CREATE PROCEDURE sp_CreateEmployee
    @EmployeeName VARCHAR(255),
    @EmployeeEmail VARCHAR(255),
    @EmployeePassword VARCHAR(255),
    @EmployeeSalary VARCHAR(255)
AS
BEGIN
    INSERT INTO Employees (EmployeeName, EmployeeEmail, EmployeePassword, EmployeeSalary)
    VALUES (@EmployeeName, @EmployeeEmail, @EmployeePassword, @EmployeeSalary)
END
GO

-- Read Stored Procedure - Retrieve employee records
CREATE PROCEDURE sp_GetEmployees
AS
BEGIN
    SELECT * FROM Employees
END
GO

-- Update Stored Procedure - Update an existing employee record
CREATE PROCEDURE sp_UpdateEmployee
    @EmployeeId INT,
    @EmployeeName VARCHAR(255),
    @EmployeeEmail VARCHAR(255),
    @EmployeePassword VARCHAR(255),
    @EmployeeSalary VARCHAR(255)
AS
BEGIN
    UPDATE Employees
    SET EmployeeName = @EmployeeName,
        EmployeeEmail = @EmployeeEmail,
        EmployeePassword = @EmployeePassword,
        EmployeeSalary = @EmployeeSalary
    WHERE EmployeeId = @EmployeeId
END
GO

-- Delete Stored Procedure - Delete an employee record
CREATE PROCEDURE sp_DeleteEmployee
    @EmployeeId INT
AS
BEGIN
    DELETE FROM Employees
    WHERE EmployeeId = @EmployeeId
END
GO

-- Read Stored Procedure - Retrieve employee records by name
CREATE PROCEDURE sp_GetEmployeesByName
    @EmployeeName VARCHAR(255)
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE EmployeeName = @EmployeeName
END
GO



-- Execute the sp_GetEmployees stored procedure:
EXEC sp_GetEmployees

-- Execute the sp_CreateEmployee stored procedure:
EXEC sp_CreateEmployee
   @EmployeeName = 'Satish Mishra',
   @EmployeeEmail = 'Satish.mishra@corecard.com',
   @EmployeePassword = 'Satish123@',
   @EmployeeSalary = '15000'

-- Execute the sp_UpdateEmployee stored procedure:
EXEC sp_UpdateEmployee
   @EmployeeId = 1,
   @EmployeeName = 'Jane Smith',
   @EmployeeEmail = 'janesmith@example.com',
   @EmployeePassword = 'newpassword456',
   @EmployeeSalary = '6000'

-- Execute the sp_DeleteEmployee stored procedure:
EXEC sp_DeleteEmployee
   @EmployeeId = 123

-- Retrieve employee records by name
EXEC sp_GetEmployeesByName
   @EmployeeName = 'Satish Mishra'
