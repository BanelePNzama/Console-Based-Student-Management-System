USE Student_Management;
GO

CREATE TABLE Students
(
    StudentId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Course VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Gender VARCHAR(20),
    BirthDate DATE,
    StudentAddress VARCHAR(255),
    StudentHasRes BIT
);