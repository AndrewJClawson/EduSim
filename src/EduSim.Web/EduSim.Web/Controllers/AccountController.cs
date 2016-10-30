﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduSim.Core.Models;
using EduSim.Web.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Web;
using System.Threading.Tasks;


using System.Web.Mvc;

using EduSim.Core.Services;

namespace EduSim.Web.Controllers
{
    public class AccountController : Controller
    {
		UserService _userService = new UserService();
		private ApplicationSignInManager _signInManager;
		private ApplicationUserManager _userManager;
        public ActionResult Index()
        {
			//var loginModel = new LoginViewModel();
			return View("Login");
        }

		[HttpPost]
		public JsonResult AuthenticateTest(string email, string password)
		{
			bool success = false;
			string message = string.Empty;
			string url = string.Empty;

			try
			{
				success = _userService.Authenticate(email,password);
				if (success)
				{
					User user = _userService.GetByCredentials(email, password);
					//sHttpContext.User = (System.Security.Principal.)user;
					UrlHelper u = new UrlHelper(this.ControllerContext.RequestContext);
					url = u.Action("Dashboard", "Account");
				}
				else
				{
					message = "User not authenticated.";
				}

			}
			catch (Exception e)
			{
				message = e.GetBaseException().Message;
				success = false;
			}
			var result = new { Success = success, Message = message, Url = url };
			return Json(result, JsonRequestBehavior.AllowGet);
		}

		public async Task<ActionResult> Authenticate(LoginViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				var user = await Microsoft.AspNet.Identity.UserManager.FindAsync(viewModel.Username, viewModel.Password);
			}
			return View("~/Views/Home/Dashboard.cshtml");
		}

    }
}
