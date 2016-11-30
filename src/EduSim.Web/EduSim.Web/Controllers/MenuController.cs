using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduSim.Web.Controllers
{
    public class MenuController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

		public ActionResult SystemAdmin(){
			return PartialView("~/Views/Home/OptionMenus/_SystemAdminMenu.cshtml");
		}

		public ActionResult AccountAdmin()
		{
			return PartialView("~/Views/Home/OptionMenus/_AccountAdminMenu.cshtml");
		}

		public ActionResult Instructor()
		{
			return PartialView("~/Views/Home/OptionMenus/_InstructorMenu.cshtml");
		}
    }
}
