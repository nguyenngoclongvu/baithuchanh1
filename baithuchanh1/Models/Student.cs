using System.ComponentModel.DataAnnotations;

namespace baithuchanh1.Models
{
    public class Student
    {
        [Key]
        public string IDStudent { get; set; }
        public string NameStudent { get; set; }
        public string PhoneStudent { get; set; }
        public string AddStudent { get; set; }
    }
}