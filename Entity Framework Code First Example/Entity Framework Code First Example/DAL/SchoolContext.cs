using Entity_Framework_Code_First_Example.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Entity_Framework_Code_First_Example.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")  // The SchoolContext is a connection string which will be defined in web.config. If you don't declare this, it will using the class name.
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }  // This can be omitted. Because enrollment is using by student.

        public DbSet<Course> Courses { get; set; }  // This can be omitted. Because course is using by enrollment.

        protected override void OnModelCreating(DbModelBuilder modelBuilder) // This can prevent 's' in name. Because we need the table name as Student, Enrollment, Course. Not like the Students above.
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}