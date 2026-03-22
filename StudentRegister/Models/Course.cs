using System.ComponentModel.DataAnnotations;

namespace StudentRegister.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }

        public List<Student> Students { get; set; }
        
    }
}
