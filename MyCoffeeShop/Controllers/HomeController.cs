using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyCoffeeShop.Models;

namespace MyCoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn more about the Java Cafe.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Success(User u)
        {
            UsersController UC = new UsersController();
            UC.Create(u);

            string freeDay = u.Birthday.Month + "-" + u.Birthday.Day;

            ViewBag.name = "Successfully Registered: " + u.FirstName + " " + u.LastName;
            ViewBag.phone = "Phone Number: " + u.PhoneNumber;
            ViewBag.email = "Email: " + u.Email;
            ViewBag.birthday = "You will receive a free cup of coffee on your birthday, " + freeDay;
            ViewBag.Message = "Thank you for becoming a registered member of the Java Cafe!";
            ViewBag.color = u.FavColor;

            return View();
        }
    }
}