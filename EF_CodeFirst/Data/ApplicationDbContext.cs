using EF_CodeFirst.Models.Dbo;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData
            (
                new Student
                {
                    StudentId = 1,
                    StudentName = "John Doe",
                    DateOfBirth = DateTime.Now.AddYears(-21),
                    Height = 185,
                    Weight = 85F
                },
                new Student
                {
                    StudentId = 2,
                    StudentName = "Jane Doe",
                    DateOfBirth = DateTime.Now.AddYears(-23),
                    Height = 160,
                    Weight = 75F
                }

            );
            
            modelBuilder.Entity<Grade>().HasData
            (
                new Grade { GradeId = 1, GradeName = "Grade 1", Section = "Section 1", StudentId = 1 },
                new Grade { GradeId = 2, GradeName = "Grade 2", Section = "Section 2", StudentId = 2 },
                new Grade { GradeId = 3, GradeName = "Grade 3", Section = "Section 3", StudentId = 1 },
                new Grade { GradeId = 4, GradeName = "Grade 4", Section = "Section 4", StudentId = 2 },
                new Grade { GradeId = 5, GradeName = "Grade 5", Section = "Section 5", StudentId = 1 },
                new Grade { GradeId = 6, GradeName = "Grade 6", Section = "Section 6", StudentId = 2 },
                new Grade { GradeId = 7, GradeName = "Grade 7", Section = "Section 7", StudentId = 1 }

            );

            

        }

    }



}
