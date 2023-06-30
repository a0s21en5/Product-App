# Employee Web Application

# Table
CREATE TABLE YourTableName (
    Emp_Id INT,
    Name VARCHAR(255),
    Email VARCHAR(255),
    Password VARCHAR(255),
    Salary VARCHAR(255)
);

> CREATE (INSERT) Procedure:
>* This procedure allows you to insert a new record into the table.
```
CREATE PROCEDURE InsertRecord
    @Emp_Id INT,
    @Name VARCHAR(255),
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Salary VARCHAR(255)
AS
BEGIN
    INSERT INTO YourTableName (Emp_Id, Name, Email, Password, Salary)
    VALUES (@Emp_Id, @Name, @Email, @Password, @Salary)
END
```

> READ (SELECT) Procedure:
>* This procedure retrieves records from the table based on the specified criteria.
```
CREATE PROCEDURE GetRecords
AS
BEGIN
    SELECT * FROM YourTableName
END
```

> UPDATE Procedure:
>* This procedure updates an existing record in the table based on the provided Emp_Id.
```
CREATE PROCEDURE UpdateRecord
    @Emp_Id INT,
    @Name VARCHAR(255),
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Salary VARCHAR(255)
AS
BEGIN
    UPDATE YourTableName
    SET Name = @Name,
        Email = @Email,
        Password = @Password,
        Salary = @Salary
    WHERE Emp_Id = @Emp_Id
END
```

> DELETE Procedure:
>* This procedure deletes a record from the table based on the provided Emp_Id.
```
CREATE PROCEDURE DeleteRecord
    @Emp_Id INT
AS
BEGIN
    DELETE FROM YourTableName
    WHERE Emp_Id = @Emp_Id
END
```
>
>*
```
```
