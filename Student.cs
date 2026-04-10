using System.ComponentModel.DataAnnotations;
namespace HoSiThinh_MVC_Test.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
