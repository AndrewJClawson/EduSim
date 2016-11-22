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
			using(var context = new EduSimContext())
			{
				var roles = context.Roles;
				foreach(var role in roles)
				{
					System.Console.WriteLine("RoleId: " + role.RoleId.ToString());
					System.Console.WriteLine("Role name: " + role.Name);
				}
			}

		}
	}
}
