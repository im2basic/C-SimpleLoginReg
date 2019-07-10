using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleLoginReg.Models;

namespace SimpleLoginReg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User NewUser)
        {
            if(ModelState.IsValid)
            {
                HttpContext.Session.SetString("Email", NewUser.Email);
            return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login (LogUser LoginUser)
        {
            if(ModelState.IsValid)
            {
                HttpContext.Session.SetString("Email", LoginUser.LoginEmail);
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }

        }
        [HttpGet("Success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Index");
            }
            else{
                return View("Success");
            }

        }
        [HttpGet("logout")]
        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
