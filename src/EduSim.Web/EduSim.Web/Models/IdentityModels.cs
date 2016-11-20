using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

	public class ApplicationRole : IdentityRole
	{
		public ApplicationRole () {}
		public ApplicationRole(string name) { Name = name}
	}

	public class ApplicationUserRole : IdentityUserRole
	{
		
	}

	public class ApplicationUserClaim : IdentityUserClaim
	{
		
	}

	public class ApplicationUserLogin : IdentityUserLogin
	{
		
	}


	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		
		public ApplicationDbContext() : base("EduSimContext")
		{
			
		}

		protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<ApplicationUser>().ToTable("users");


		}
	}


}
