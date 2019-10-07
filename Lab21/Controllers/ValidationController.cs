using Lab21.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Html5()
        {
            return View();
        }

        public IActionResult DataAno()
        {
            return View();
        }

        public IActionResult UserResult(User u)
        {
            if (ModelState.IsValid)
            {
                return View(u);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult ControllerSide()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
