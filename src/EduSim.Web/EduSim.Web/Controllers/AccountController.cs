using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
//using EduSim.Core.Models;
using EduSim.Core.ModelInterfaces;
using EduSim.Web.ViewModels;
using EduSim.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.Owin.Security;
using Microsoft.Web;
using System.Threading.Tasks;


using System.Web.Mvc;

using EduSim.Core.Services;

namespace EduSim.Web.Controllers
{
    public class AccountController : Controller
    {
		IProfileService _profileService;
		//private ApplicationSignInManager _signInManager;
		//private ApplicationUserManager _userManager;

		public AccountController(IProfileService profileService)
		{
			_profileService = profileService;
		}

        public ActionResult Index()
        {
			//var loginModel = new LoginViewModel();
			return View("Login");
        }

		public async Task<ActionResult> Dashboard(LoginViewModel viewModel)
		{
			ApplicationUser myUser;
			ApplicationUserStore store = new ApplicationUserStore(new ApplicationDbContext());
			ApplicationUserManager userManager = new ApplicationUserManager(store);

			//myUser = new ApplicationUser() { UserName = "TestUser", Email = "TestUser@test.com"};
			//string passwordHash = userManager.PasswordHasher.HashPassword("testPassword");
			//myUser.PasswordHash = passwordHash;
			myUser = await userManager.FindAsync(viewModel.Username, viewModel.Password);

			if (myUser == null)
			{
				
				return View("Login");//ViewBag["Errors"] = result.Result.Errors.First();
			}
			else{
				var profile = _profileService.GetForUser(myUser.Id);
				System.Web.HttpContext.Current.Session["CurrentUser"] = myUser;

				return View("~/Views/Home/Dashboard.cshtml");
			}

		}


    }
}
