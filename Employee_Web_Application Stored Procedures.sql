-- CREATE (INSERT) Procedure:
CREATE PROCEDURE InsertRecord
    @Emp_Id INT,
    @Name VARCHAR(255),
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Salary VARCHAR(255)
AS
BEGIN
    INSERT INTO Employee (Emp_Id, Name, Email, Password, Salary)
    VALUES (@Emp_Id, @Name, @Email, @Password, @Salary)
END


-- READ (SELECT) Procedure:
CREATE PROCEDURE GetRecords
AS
BEGIN
    SELECT * FROM Employee
END


-- UPDATE Procedure:
CREATE PROCEDURE UpdateRecord
    @Emp_Id INT,
    @Name VARCHAR(255),
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Salary VARCHAR(255)
AS
BEGIN
    UPDATE Employee
    SET Name = @Name,
        Email = @Email,
        Password = @Password,
        Salary = @Salary
    WHERE Emp_Id = @Emp_Id
END


-- DELETE Procedure:
CREATE PROCEDURE DeleteRecord
    @Emp_Id INT
AS
BEGIN
    DELETE FROM Employee
    WHERE Emp_Id = @Emp_Id
END

-- GetEmployeeById:
CREATE PROCEDURE GetEmployeeById
    @Emp_Id INT
AS
BEGIN
    SELECT * FROM Employee WHERE Emp_Id = @Emp_Id
END


-- GetEmployeeByName:
CREATE PROCEDURE GetEmployeeByName
    @Name VARCHAR(255)
AS
BEGIN
    SELECT * FROM Employee WHERE Name = @Name
END



-- Execute the CREATE (INSERT) procedure
EXEC InsertRecord @Emp_Id = 1, @Name = 'John Doe', @Email = 'john@example.com', @Password = 'password123', @Salary = '5000';

-- Execute the READ (SELECT) procedure
EXEC GetRecords;

-- Execute the UPDATE procedure
EXEC UpdateRecord @Emp_Id = 1, @Name = 'John Doe Updated', @Email = 'john@example.com', @Password = 'newpassword', @Salary = '6000';

-- Execute the DELETE procedure
EXEC DeleteRecord @Emp_Id = 1;

-- Execute GetEmployeeById
EXEC GetEmployeeById @Emp_Id = 1;

-- Execute GetEmployeeByName
EXEC GetEmployeeByName @Name = 'John Doe';
