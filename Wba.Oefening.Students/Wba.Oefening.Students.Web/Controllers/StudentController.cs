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
            studentDetailsVm.StudentName = studentRepository.GetStudents().FirstOrDefault(s => s.Id == id)?.FirstName ?? "no firstname" +
                studentRepository.GetStudents().FirstOrDefault(s => s.Id == id)?.LastName ?? "noLastName";
            studentDetailsVm.Course = studentRepository.GetStudents().FirstOrDefault(s => s.Id == id).Course;

            return View(studentDetailsVm);
        }
    }
}
