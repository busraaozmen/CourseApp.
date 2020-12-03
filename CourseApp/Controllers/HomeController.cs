using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CourseApp.Models.Request model = new Models.Request();
            model.Name = "Büşra Özmen";
            model.Phone = "012344556789";
            model.Email = "busraozmen@outlook.com";
            model.Message = "Limon bahçesi yapacağım.";
            return View(model);

        }
    }
}
