using MVC_TP_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TP_FINAL.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            Users user = new Users(Session["MainDB"]);
            user.SelectAll();
            return View(user);
        }

	}
}