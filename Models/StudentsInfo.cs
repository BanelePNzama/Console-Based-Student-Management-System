using System;
using System.ComponentModel.DataAnnotations;


namespace Console_Based_Student_Management_System.Student_Management.Models
{
    public class StudentsInfo
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string CourseName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string StudentGender { get; set; }
        public DateTime StudentBirthDate { get; set; }
        public string StudentAddress { get; set; }
        public bool StudentHasRes { get; set; }
    }
}
