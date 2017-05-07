using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using EduSim.Core.Models
using EduSim.Core.ModelInterfaces;
using EduSim.Web.ViewModels;
using EduSim.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.Owin.Security
using Microsoft.Web;
using System.Threading.Tasks;


using System.Web.Mvc;

using EduSim.Core.Services;

namespace EduSim.Web.Controllers
{
    public class SystemAdminController : Controller
    {
		//private ILookupService _lookupService;
		private IAccountService _accountService;
		private IPermissionService _permissionService;
		public SystemAdminController(IAccountService accountService, IPermissionService permissionService)
		{
			//_lookupService = lookupService;
			_accountService = accountService;
			_permissionService = permissionService;
		}

        public ActionResult Roles()
        {
			SystemRolesViewModel viewModel = new SystemRolesViewModel();
			viewModel.Roles = _permissionService.GetRoles().ToList();

            return View("/Views/SystemAdmin/Roles/Roles.cshtml",viewModel);
        }

		public ActionResult Users()
		{
			return View("/Views/SystemAdmin/Users/Users.cshtml");
		}

		public ActionResult Accounts()
		{
			SystemAccountsViewModel viewModel
				= ViewModelFactory.CreateSystemAccountsListViewModel(_accountService);
			ViewData["AccountTypes"] = new SelectList(_accountService.GetAccountTypes(), "AccountTypeId", "Name");
			return View("/Views/SystemAdmin/Accounts/Accounts.cshtml", viewModel);
		}

		public ActionResult DashboardMenu()
		{
			return PartialView("~/Views/SystemAdmin/_SystemAdminMenu.cshtml");
		}
    }
}
