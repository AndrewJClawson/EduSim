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

		[HttpPost]
		public JsonResult Authenticate(string email, string password)
		{
			bool success = false;
			string message = string.Empty;
			string url = string.Empty;
			try
			{
				success = true;
				UrlHelper u = new UrlHelper(this.ControllerContext.RequestContext);
				url = u.Action("Dashboard", "Account");
			}
			catch (Exception e)
			{
				message = e.GetBaseException().Message;
				success = false;
			}
			var result = new { Success = success, Message = message, Url = url };
			return Json(result, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Dashboard(LoginViewModel viewModel)
		{
			return View("~/Views/Home/Dashboard.cshtml");
		}
    }
}
