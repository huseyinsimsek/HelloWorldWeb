using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldWeb.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Detail(int id)
        {
            string[] names = new string[] { "Hüseyin Şimşek", "Ahmet Kaya", "Murat Ali" };

            //Get from db;
            Student student = new Student();
            student.Id = id;
            student.Name = names[id % names.Length];
            student.Age = id*8+5;


            return View(student);
        }
    }
}
