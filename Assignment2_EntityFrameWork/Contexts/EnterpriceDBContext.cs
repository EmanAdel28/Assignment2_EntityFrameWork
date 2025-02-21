using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Assignment2_EntityFrameWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_EntityFrameWork.Contexts
{
    internal class EnterpriceDBContext:DbContext
    {

        #region Property
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }


        public DbSet<Course_Inst> Course_Inst { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; Database = ITIDB ; Trusted_Connection = true ;TrustServerCertificate =true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Course>()
                        .HasOne(T => T.Topic)
                        .WithOne(C => C.Course)
                        .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
