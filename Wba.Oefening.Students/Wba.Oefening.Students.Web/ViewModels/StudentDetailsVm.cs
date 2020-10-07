using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.Students.Domain;

namespace Wba.Oefening.Students.Web.ViewModels
{
    public class StudentDetailsVm
    {
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
    }
}
