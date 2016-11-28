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
		ILookupService _lookupService;
		IAccountService _accountService;
		//private ApplicationSignInManager _signInManager;
		//private ApplicationUserManager _userManager;

		public AccountController(IAccountService accountService, IProfileService profileService, ILookupService lookupService)
		{
			_accountService = accountService;
			_profileService = profileService;
			_lookupService = lookupService;
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
				System.Web.HttpContext.Current.Session["CurrentProfile"] = profile;
				return View("~/Views/Home/Dashboard.cshtml");
			}

		}

		public ActionResult Logout()
		{
			System.Web.HttpContext.Current.Session["CurrentUser"] = null;
			return RedirectToAction("Index");
		}

		public ActionResult Details(int? accountId)
		{
			AccountDetailsViewModel viewModel = ViewModelFactory.CreateAccountDetailsViewModel(
				_accountService, _lookupService, accountId); 

			return PartialView("/Views/Account/_AccountDetailsPartial.cshtml", viewModel);
		}

		public ActionResult Save(AccountDetailsViewModel accountViewModel)
		{
			if (accountViewModel.Account.AccountId > 0)
			{
				_accountService.Update(accountViewModel.Account);
			}
			else
			{
				_accountService.Create(accountViewModel.Account.AccountName, accountViewModel.Account.AccountTypeId);	
			}
			return View("~/Views/Home/Dashboard.cshtml");
		}

    }
}
