using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models.Dbo
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
    }
}
