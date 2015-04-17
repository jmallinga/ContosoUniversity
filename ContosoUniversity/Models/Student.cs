using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }    //ID is property which is also an interger, it is the primary key column of the database table of this class (Student) 
        public string LastName { get; set; }   //LastName is the NameSpace of a string (which is a type)
        public string FirstMidName { get; set; } //FirstMidName is the NameSpace of a string (which is a type)
        public DateTime EnrollmentDate { get; set; }  //EnrollmentDate is the namespace of type which is formatted as DateTime

        public virtual ICollection<Enrollment> Enrollments { get; set; } //The Enrollments property is a navigation property that hold other entities that are related to this entity

    }
}