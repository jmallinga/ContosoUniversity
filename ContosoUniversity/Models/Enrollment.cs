using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Logging
{
    public enum Grade //enum is a property of Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } //EnrollmentID is a primary key
        public int CourseID { get; set; }  //CourseID is a foreign key, the navigation property is course 
        public int StudentID { get; set; } //StudentID is a foreign key, the navigation property is student
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}