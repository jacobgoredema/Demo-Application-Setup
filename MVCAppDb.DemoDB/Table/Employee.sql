CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EmployeeId] INT NOT NULL, 
    [Firstname] NCHAR(10) NOT NULL, 
    [Lastname] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL
)
