using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduSim.Web.ViewModels;
using System.Web.Mvc;

namespace EduSim.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
			//var loginModel = new LoginViewModel();
			return View("Login");
        }

		public ActionResult Login(LoginViewModel viewModel)
		{
			return View("~/Views/Home/Dashboard.cshtml");
		}
    }
}
