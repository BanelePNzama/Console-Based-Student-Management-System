using Console_Based_Student_Management_System.Student_Management.Models;
using System.Data.Entity;

namespace Console_Based_Student_Management_System.Student_Management
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
            : base("name=StudentDbContext")
        {
        }

        public DbSet<StudentsInfo> Students { get; set; }
    }
}