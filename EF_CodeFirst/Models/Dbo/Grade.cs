﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models.Dbo
{
    public class Grade
    {
        [Key] 
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        
        [ForeignKey("StudentId")] 
        public int StudentId { get; set; }
    }
}
