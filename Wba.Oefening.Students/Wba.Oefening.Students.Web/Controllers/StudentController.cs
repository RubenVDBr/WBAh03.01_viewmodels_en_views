using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Students.Domain;
using Wba.Oefening.Students.Web.ViewModels;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository studentRepository;

        public StudentController()
        {
            studentRepository = new StudentRepository();
        }

        [Route("Students/index")]
        public IActionResult Index()
        {
            ViewData["pageTitle"] = "Studentpage";
            ViewBag.Message = "Welcome to the student index page";

            return View();
        }

        [Route("students/details/{id:int}")]
        public IActionResult Details(int id)
        {
            //Viewmodel aanmaken
            var studentDetailsVm = new StudentDetailsVm();

            //Viewmodel vullen
            studentDetailsVm.StudentId = studentRepository.GetStudents().FirstOrDefault(s => s.Id == id)?.Id ?? 0;
            studentDetailsVm.StudentName = $"{studentRepository.GetStudents().FirstOrDefault(s => s.Id == id)?.FirstName ?? "no firstname"} " +
                                            $"{studentRepository.GetStudents().FirstOrDefault(s => s.Id == id)?.LastName ?? "noLastName"}";
            studentDetailsVm.CourseName = studentRepository.GetStudents().FirstOrDefault(s => s.Id == id)?.Course?.Name ?? "noCourse";

            return View(studentDetailsVm);
        }

        [Route("students/all")]
        public IActionResult AllStudents()
        {
            //studentRepository ophalen
            var studenten = new StudentRepository().GetStudents();

            //Viewmodel aanmaken
            var studentAllStudentsVm = new StudentAllStudentsVm();

            //lijst initialiseren
            studentAllStudentsVm.Studenten = new List<string>();

            //Viewmodel vullen
            foreach (Student student in studenten)
            {
                studentAllStudentsVm.Studenten.Add($"{student?.FirstName ?? "noFirstName"} {student?.LastName ?? "noLastName"}");
            }

            return View(studentAllStudentsVm);
        }
    }
}
