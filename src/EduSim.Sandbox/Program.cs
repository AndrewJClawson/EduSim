using System;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.Contexts;
using System.Linq;
using System.Data;
using System.Data.Entity;
using EduSim.Core.Services;

namespace EduSim.Sandbox
{
	class MainClass
	{
		public static AccountService _accountService = new AccountService();
		public static ProfileService _profileService = new ProfileService();

		public static void Main(string[] args)
		{
			using(EduSimContext context = new EduSimContext())
			{
				var roles = context
				foreach(var profile in profiles)
				{
					System.Console.WriteLine("User Id: " + profile.UserId);
					System.Console.WriteLine("Account Id: " + profile.AccountId);
				}
			}

			System.Console.WriteLine(true);
		}
	}
}
