using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using EduSim.Web.Models;
namespace EduSim.Web
{
	public class ApplicationUserStore : UserStore<ApplicationUser>
	{
		public ApplicationUserStore(ApplicationDbContext context):base(context)
		{
		}
	}

	public class ApplicationRoleStore : RoleStore<ApplicationRole>
	{
		public ApplicationRoleStore(ApplicationDbContext context):base(context)
		{
			
		}
	}

	public class ApplicationUserManager : UserManager<ApplicationUser>
	{
		public ApplicationUserManager(IUserStore<ApplicationUser> store): base(store)
		{
			
		}
	}
}
