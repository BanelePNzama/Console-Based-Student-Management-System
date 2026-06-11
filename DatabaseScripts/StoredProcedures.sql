-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Banele Promise Nzama>
-- Create date: <11/06/2026>
-- Description:	<Created this proc to add students in the database>
-- =============================================
USE [Student_Management]
GO
/****** Object:  StoredProcedure [dbo].[AddStudents]    Script Date: 2026/06/11 04:43:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[AddStudents]
(
    @StudentName VARCHAR(50),
    @StudentSurname VARCHAR(50),
    @CourseName VARCHAR(100),
    @StudentEmail VARCHAR(100),
    @StudentPhone VARCHAR(20),
    @StudentGender VARCHAR(20),
    @StudentBirthDate DATE,
    @StudentAddress VARCHAR(255),
    @StudentHasRes BIT
)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Students
    (
        FirstName,
        LastName,
        Course,
        Email,
        Phone,
        Gender,
        BirthDate,
        StudentAddress,
        StudentHasRes
    )
    VALUES
    (
        @StudentName,
        @StudentSurname,
        @CourseName,
        @StudentEmail,
        @StudentPhone,
        @StudentGender,
        @StudentBirthDate,
        @StudentAddress,
        @StudentHasRes
    );
END

USE [Student_Management]
GO
/****** Object:  StoredProcedure [dbo].[DeleteStudent]    Script Date: 2026/06/11 04:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Banele P Nzama>
-- Create date: <09/06/2026>
-- Description:	<Stored procedure to delete a student>
-- =============================================
ALTER PROCEDURE [dbo].[DeleteStudent]
    @studentId INT
AS
BEGIN
    DELETE FROM Students
    WHERE StudentId = @studentId
END


USE [Student_Management]
GO
/****** Object:  StoredProcedure [dbo].[GetAllStudents]    Script Date: 2026/06/11 04:40:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetAllStudents]
AS
BEGIN
    SELECT 
        StudentId,
        FirstName AS StudentName,
        LastName AS StudentSurname,
        Course AS CourseName,
        Email AS StudentEmail,
        Phone AS StudentPhone,
        Gender AS StudentGender,
        BirthDate AS StudentBirthDate,
        StudentAddress AS StudentAddress,
        StudentHasRes AS StudentHasRes
    FROM Students
END

USE [Student_Management]
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 2026/06/11 04:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Banele P Nzama>
-- Create date: <09/06/2026>
-- Description:	<Update Students info stored proc>
-- =============================================
ALTER PROCEDURE [dbo].[UpdateStudent]
(
    @StudentId INT,
    @StudentName VARCHAR(50),
    @StudentSurname VARCHAR(50),
    @CourseName VARCHAR(100),
    @StudentEmail VARCHAR(100),
    @StudentPhone VARCHAR(20),
    @StudentGender VARCHAR(20),
    @StudentBirthDate DATE,
    @StudentAddress VARCHAR(255),
    @StudentHasRes BIT
)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Students
    SET 
        FirstName = @StudentName,
        LastName = @StudentSurname,
        Course = @CourseName,
        Email = @StudentEmail,
        Phone = @StudentPhone,
        Gender = @StudentGender,
        BirthDate = @StudentBirthDate,
        StudentAddress = @StudentAddress,
        StudentHasRes = @StudentHasRes
    WHERE StudentId = @StudentId;
END
