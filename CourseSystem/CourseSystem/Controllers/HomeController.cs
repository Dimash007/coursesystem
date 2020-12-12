using CourseSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CourseSystem.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "admin, user, teacher")]
        public IActionResult Index()
        {
            string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            return View();
        }
        [Authorize(Roles = "admin")]
        public IActionResult Home()
        {
            return Content("Вход только для администратора");
        }
    }
}
