using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevSkill.LibrarySystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSkill.LibrarySystem.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}