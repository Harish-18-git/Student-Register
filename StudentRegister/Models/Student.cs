using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRegister.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        [ForeignKey("Course")]
        public int courseid { get; set; }
        public List<Topic> topics { get; set; }

        public List<Course> Courses { get; set; }
    }
}
