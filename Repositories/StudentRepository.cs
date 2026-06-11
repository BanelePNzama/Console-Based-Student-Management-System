using Console_Based_Student_Management_System.Student_Management.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Console_Based_Student_Management_System.Student_Management
{
    public class StudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository()
        {
            _context = new StudentDbContext();
        }

        public void AddStudent(StudentsInfo student)
        {
            _context.Database.ExecuteSqlCommand(
               "EXEC dbo.AddStudents @StudentName, @StudentSurname, @CourseName, @StudentEmail, @StudentPhone, @StudentGender, @StudentBirthDate, @StudentAddress, @StudentHasRes", new SqlParameter("@StudentName", student.StudentName),
                new SqlParameter("@StudentSurname", student.StudentSurname),
                new SqlParameter("@CourseName", student.CourseName),
                new SqlParameter("@StudentEmail", student.StudentEmail),
                new SqlParameter("@StudentPhone", student.StudentPhone),
                new SqlParameter("@StudentGender", student.StudentGender),
                new SqlParameter("@StudentBirthDate", student.StudentBirthDate),
                new SqlParameter("@StudentAddress", student.StudentAddress),
                new SqlParameter("@StudentHasRes", student.StudentHasRes)
            );
        }

        public void UpdateStudent(StudentsInfo student)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC UpdateStudent @StudentId, @StudentName, @StudentSurname, @CourseName, @StudentEmail, @StudentPhone, @StudentGender, @StudentBirthDate, @StudentAddress, @StudentHasRes",
                new SqlParameter("@StudentId", student.StudentId),
                new SqlParameter("@StudentName", student.StudentName),
                new SqlParameter("@StudentSurname", student.StudentSurname),
                new SqlParameter("@CourseName", student.CourseName),
                new SqlParameter("@StudentEmail", student.StudentEmail),
                new SqlParameter("@StudentPhone", student.StudentPhone),
                new SqlParameter("@StudentGender", student.StudentGender),
                new SqlParameter("@StudentBirthDate", student.StudentBirthDate),
                new SqlParameter("@StudentAddress", student.StudentAddress),
                new SqlParameter("@StudentHasRes", student.StudentHasRes)
            );
        }

        public void RemoveStudent(int studentId)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC DeleteStudent @StudentId",
                new SqlParameter("@StudentId", studentId)
            );
        }

        public List<StudentsInfo> GetAllStudents()
        {
            return _context.Database.SqlQuery<StudentsInfo>("EXEC GetAllStudents").ToList();
        }
    }
}