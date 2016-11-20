using System;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.Contexts;
using System.Linq;
using System.Data;
using System.Data.Entity;
using EduSim.Core.Services;
using EduSim.Web;
using EduSim.Web.Models;

namespace EduSim.Sandbox
{
	class MainClass
	{
		public static AccountService _accountService = new AccountService();
		public static ProfileService _profileService = new ProfileService();

		public static void Main(string[] args)
		{
			//ApplicationUser myUser;
			//ApplicationUserStore store = new ApplicationUserStore(new ApplicationDbContext());
			//ApplicationUserManager userManager = new EduSim.Web.ApplicationUserManager(store);

			//myUser = new ApplicationUser() { UserName = "aclawson", Email = "andrewjclawson18@gmail.com"};
			//string passwordHash = userManager.PasswordHasher.HashPassword("clawson1");
			//myUser.PasswordHash = passwordHash;

			//userManager.CreateAsync(myUser);

		}
	}
}
