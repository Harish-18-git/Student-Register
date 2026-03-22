using System.ComponentModel.DataAnnotations;

namespace StudentRegister.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
