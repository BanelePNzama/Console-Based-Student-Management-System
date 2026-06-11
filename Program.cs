using Console_Based_Student_Management_System.Services;
using Console_Based_Student_Management_System.Student_Management.Models;
using Console_Based_Student_Management_System.Student_Management.Views;
using System;


namespace Console_Based_Student_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentBusiness business = new StudentBusiness();
            StudentView view = new StudentView();

            while (true)
            {
                Console.WriteLine("\n=== STUDENT SYSTEM ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. View All Students");
                Console.WriteLine("5. Exit");
                Console.Write("Select option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    var student = view.CaptureStudent();
                    business.AddStudent(student);
                    Console.WriteLine("Student added!");
                }

                else if (choice == "2")
                {
                    Console.Write("Enter Student ID to remove: ");
                    int id = int.Parse(Console.ReadLine());

                    StudentsInfo student = new StudentsInfo
                    {
                        StudentId = id
                    };

                    business.RemoveStudent(student);

                    Console.WriteLine("Student removed!");
                }
                else if (choice == "3")
                {
                    Console.Write("Enter Student ID to update: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter new details:");

                    var student = view.CaptureStudent();
                    student.StudentId = id;

                    business.UpdateStudent(student);

                    Console.WriteLine("Student updated!");
                }

                else if (choice == "4")
                {
                    var students = business.GetAllStudents();

                    foreach (var s in students)
                    {
                        Console.WriteLine($"{s.StudentId} - {s.StudentName} {s.StudentSurname}");
                    }
                }
                else if (choice == "5")
                {
                    break;
                }
            }
        }
    }
}
