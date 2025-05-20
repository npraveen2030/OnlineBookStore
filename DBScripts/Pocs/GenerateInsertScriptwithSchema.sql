CREATE SCHEMA poc;

CREATE TABLE poc.Employee (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Age INT NOT NULL
);

-- Insert 5 sample records
INSERT INTO poc.Employee (Name, Age) VALUES
('Alice Johnson', 28),
('Bob Smith', 35),
('Charlie Evans', 42),
('Diana Lee', 30),
('Edward Brown', 25);


DECLARE @sql NVARCHAR(MAX) = '';

SELECT @sql += 
 'INSERT INTO poc.employee (id, name, age) VALUES (' + CAST(id AS NVARCHAR) + ', ''' + REPLACE(name, '''', '''''') + ''', ' +  CAST(age AS NVARCHAR) + ');' + CHAR(13)
FROM poc.employee;

PRINT @sql;

