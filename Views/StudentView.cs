using Console_Based_Student_Management_System.Student_Management.Models;
using System;

namespace Console_Based_Student_Management_System.Student_Management.Views
{
    public class StudentView
    {
        public StudentsInfo CaptureStudent()
        {
            StudentsInfo student = new StudentsInfo();

            // FIRST NAME
            Console.Write("First Name: ");
            string firstname = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(firstname))
            {
                Console.Write("First Name cannot be empty: ");
                firstname = Console.ReadLine();
            }

            student.StudentName = firstname.Trim();

            // LAST NAME
            Console.Write("Last Name: ");
            string lastname = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(lastname))
            {
                Console.Write("Last Name cannot be empty: ");
                lastname = Console.ReadLine();
            }

            student.StudentSurname = lastname.Trim();

            // COURSE NAME
            Console.Write("Course Name: ");
            string course = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(course))
            {
                Console.Write("Course Name cannot be empty: ");
                course = Console.ReadLine();
            }

            student.CourseName = course.Trim();

            // EMAIL
            Console.Write("Email: ");
            string email = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(email))
            {
                Console.Write("Email cannot be empty: ");
                email = Console.ReadLine();
            }

            student.StudentEmail = email.Trim();

            // PHONE
            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(phone))
            {
                Console.Write("Phone cannot be empty: ");
                phone = Console.ReadLine();
            }

            student.StudentPhone = phone.Trim();

            // GENDER
            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(gender))
            {
                Console.Write("Gender cannot be empty: ");
                gender = Console.ReadLine();
            }

            student.StudentGender = gender.Trim();

            // ADDRESS
            Console.Write("Home Address: ");
            string address = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(address))
            {
                Console.Write("Home Address cannot be empty: ");
                address = Console.ReadLine();
            }

            student.StudentAddress = address.Trim();

            // DATE OF BIRTH
            Console.Write("Date of Birth: ");
            string birthDateInput = Console.ReadLine();

            while (!DateTime.TryParse(birthDateInput, out DateTime birthDate))
            {
                Console.Write("Invalid date. Enter again (e.g. 2000-01-01): ");
                birthDateInput = Console.ReadLine();
            }

            student.StudentBirthDate = Convert.ToDateTime(birthDateInput);

            // RESIDENCE
            Console.Write("Do you stay at Res? (yes/no): ");
            string hasResInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(hasResInput) ||
                  (hasResInput.ToLower() != "yes" && hasResInput.ToLower() != "no"))
            {
                Console.Write("Please enter yes or no: ");
                hasResInput = Console.ReadLine();
            }

            student.StudentHasRes = hasResInput.Equals("yes", StringComparison.OrdinalIgnoreCase);

            return student;
        }


    }
}
