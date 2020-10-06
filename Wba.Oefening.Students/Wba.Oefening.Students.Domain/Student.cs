using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.Oefening.Students.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Course Course { get; set; }
    }
}
