using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_Student_Management_System.Student_Management
{
    class StudentsInfo
    {
        public int studentId {  get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string courseName { get; set; }
        public string studentEmail { get; set; }
        public string studentPhone { get; set; }
        public int studentAge { get; set; }
        public string studentGender { get; set; }
        public DateTime studentBirthDate { get; set; }
        public string studentAddress { get; set; }
        public bool? studentHasRes {  get; set; }
    }
}
