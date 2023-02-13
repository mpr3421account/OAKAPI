using System.ComponentModel.DataAnnotations;

namespace OAKAPI.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }


    }
}
