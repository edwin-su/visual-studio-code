using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity_Framework_Code_First_Example.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        // This primary key is just an example. The application should follow the same rule. Using Id as the primary key or using the class name + id as the primary key.
        public int EnrollmentID { get; set; } 

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}