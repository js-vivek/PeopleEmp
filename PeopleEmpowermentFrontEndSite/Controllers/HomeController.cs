
using PeopleEmpowermentFrontEndSite.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleEmpowermentFrontEndSite.Controllers
{
    public class HomeController : Controller
    {
        UserService.UserServiceClient userService = new UserService.UserServiceClient();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            UserDetail user = new UserDetail();
            user = userService.AddUser(user);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}