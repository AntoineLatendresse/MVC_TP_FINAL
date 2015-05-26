using MVC_TP_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TP_FINAL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Modify(Users user)
        {
            return View(user);
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult List()
        {
            Users user = new Users(Session["MainDB"]);
            user.SelectAll();
            return View(user);
        }

        public ActionResult Subscribe()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}