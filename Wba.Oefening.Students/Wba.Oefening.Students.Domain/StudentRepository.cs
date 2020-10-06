using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wba.Oefening.Students.Domain
{
    public class StudentRepository
    {
        public IEnumerable<Student> GetStudents()
        {
            CourseRepository courseRepository = new CourseRepository();

            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Arno",
                    LastName = "muttn",
                    Course = courseRepository.GetCourses().First(c => c.Id == 1)
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Fay",
                    LastName = "noidea",
                    Course = courseRepository.GetCourses().First(c => c.Id == 2)
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Silke",
                    LastName = "vanlokeren",
                    Course = courseRepository.GetCourses().First(c => c.Id == 3)
                }
            };
        }
    }
}
