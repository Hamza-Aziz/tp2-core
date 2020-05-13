using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using exo1tp2core.Models;
using Microsoft.AspNetCore.Http;

namespace exo1tp2core.Controllers
{
    public class HomeController : Controller
    {
        string nom = "aziz";
        string prenom = "hamza";
        [HttpPost]
        public ViewResult login(string nom, string prenom)
        {
            if (nom.Equals(this.nom) && prenom.Equals(this.prenom))
            {
                User user = new User(nom, prenom);
                ViewBag.nom = nom;
                ViewBag.prenom = prenom;
                //cookies
                //CookieOptions option = new CookieOptions();
                //option.HttpOnly = true;
                //Response.Cookies.Append("name", user.Nom);
                //Response.Cookies.Append("prenom", user.Prenom);
                //session
                HttpContext.Session.SetString("name", user.Nom);
                HttpContext.Session.SetString("name", user.Nom);
                return View("login");
            }
            else
            {
                return View ("Index");
            }

        }
        [HttpGet]
        public ViewResult login()
        {
            //if (this.ControllerContext.HttpContext.Request.Cookies ["name"] != null)
            //{
            //    ViewBag.nom = this.ControllerContext.HttpContext.Request.Cookies["name"];
            //    //session
            //    ViewBag.nom = HttpContext.Session.GetString("name");

            //    return View("login");
            //}
            //else
            //{
            //    return View("Index");
            //}
            //session
            if (HttpContext.Session.GetString("name") != null)
            {
                //session
                ViewBag.nom = HttpContext.Session.GetString("name");

                return View("login");
            }
            else
            {
                return View("Index");
            }
        }
        public ViewResult Logout()
        {
            //Response.Cookies.Delete("name");
            //session
            HttpContext.Session.Remove("name");
            return View("Index");
        }
    }
}
