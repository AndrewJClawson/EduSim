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
        public ActionResult Login()
        {
			//var loginModel = new LoginViewModel();
			return View();
        }
    }
}
