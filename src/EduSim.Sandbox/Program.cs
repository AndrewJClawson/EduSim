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
			
			System.Console.WriteLine(true);
		}
	}
}
