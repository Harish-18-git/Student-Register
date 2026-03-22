using Microsoft.EntityFrameworkCore;

namespace StudentRegister.Models
{
    public class StudentRegisterDbContext:DbContext
    {
        public StudentRegisterDbContext(DbContextOptions<StudentRegisterDbContext> options) : base(options)
        {
        }   

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }

       
    }
}
