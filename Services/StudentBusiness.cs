using Console_Based_Student_Management_System.Student_Management;
using Console_Based_Student_Management_System.Student_Management.Models;
using System.Collections.Generic;


namespace Console_Based_Student_Management_System.Services
{
    public class StudentBusiness
    {
        private readonly StudentRepository _repository;


        public StudentBusiness()
        {
            _repository = new StudentRepository();
        }

        public void AddStudent(StudentsInfo student)
        {
            if (student == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(student.StudentName) ||
                string.IsNullOrWhiteSpace(student.StudentSurname))
            {
                return;
            }
            _repository.AddStudent(student);
        }

        public void RemoveStudent(StudentsInfo student) 
        {
            if (student == null || student.StudentId <= 0)
            {
                return;
            }
            _repository.RemoveStudent(student.StudentId);
        }

        public void UpdateStudent(StudentsInfo student)
        {
            if (student == null || student.StudentId <= 0)
            {
                return;
            }
            _repository.UpdateStudent(student);
        }
        public List<StudentsInfo> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }


    }
}