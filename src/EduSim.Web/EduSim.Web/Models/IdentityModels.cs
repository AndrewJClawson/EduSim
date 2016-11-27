using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core;
using EduSim.Core.Contexts;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EduSim.Web.Models
{
	[Table("users")]
	public class ApplicationUser : IdentityUser
	{
		
		public static ApplicationUser Current
		{
			get
			{
				var user = HttpContext.Current.Session["CurrentUser"] as ApplicationUser;
				return user;
			}

		}
	}

	//public class ApplicationRole : IdentityRole
	//{
	//	public ApplicationRole () {}
	//	public ApplicationRole(string name) { Name = name;}
	//}

	//public class ApplicationUserRole : IdentityUserRole
	//{
		
	//}

	//public class ApplicationUserClaim : IdentityUserClaim
	//{
		
	//}

	//public class ApplicationUserLogin : IdentityUserLogin
	//{
		
	//}


	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		
		public ApplicationDbContext() : base("server=localhost;user id=edusim;password=store_d@t@;database=edusim_auth")
		{
			
		}

		protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<ApplicationUser>().ToTable("users");
		}
	}


}
