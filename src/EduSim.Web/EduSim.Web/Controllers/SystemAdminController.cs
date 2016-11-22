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
		private ILookupService _lookupService;
		public SystemAdminController(ILookupService lookupService)
		{
			_lookupService = lookupService;
		}

        public ActionResult Roles()
        {
			SystemRolesViewModel viewModel = new SystemRolesViewModel();
			viewModel.Roles = _lookupService.GetRoles();

            return View("/Views/SystemAdmin/Roles/Roles.cshtml",viewModel);
        }
    }
}
