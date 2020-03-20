using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Models;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic;

namespace eUseControl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISession _session;
        public HomeController()
        {
            var bl = new MyBusinessLogic();
            _session = bl.getSessionBL();
        }
        // GET: Home
        public ActionResult Index()
        {
            UserData u = new UserData();
            u.Username = "ion";
            u.Products = new List<string> { "1", "2" };
            return View(u);
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}