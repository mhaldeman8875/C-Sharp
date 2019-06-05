using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        // The name of the connection string (which you'll add to the Web.config file later) is passed in to the constructor:
        public SchoolContext() : base("SchoolContext")
        {
        }

        //You can omit the DbSet<Enrollment> and DbSet<Course> statements and it would work the same. 
        //Entity Framework would include them implicitly because the Student entity references the 
        //Enrollment entity and the Enrollment entity references the Course entity:
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

//The modelBuilder.Conventions.Remove statement in the OnModelCreating method prevents table names 
//from being pluralized. If you didn't do this, the generated tables in the database would be named 
//Students, Courses, and Enrollments. Instead, the table names will be Student, Course, and Enrollment. 
//Developers disagree about whether table names should be pluralized or not. This tutorial uses the 
//singular form, but the important point is that you can select whichever form you prefer by including 
//or omitting this line of code.