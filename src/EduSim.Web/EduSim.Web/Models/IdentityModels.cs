using System;
using EduSim.Core;
using EduSim.Core.Contexts;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EduSim.Web.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ApplicationUser()
		{
		}
	}

	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext() : base("EduSimContext")
		{
			
		}
	}


}
