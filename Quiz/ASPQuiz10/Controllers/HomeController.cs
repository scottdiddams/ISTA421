using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPQuiz10.Models;

namespace ASPQuiz10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddPerson(Person person)
        {
            if (ModelState.IsValid)
            {
                PeopleRepository.AddResponse(person);
                return View("Thanks", person);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListPeople()
        {
            return View(PeopleRepository.NewPeople);
        }
    }
}

