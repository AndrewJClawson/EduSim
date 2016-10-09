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
		public static UserService _userService = new UserService();

		public static void Main(string[] args)
		{
			bool authenticated = _userService.Authenticate("andrewjclawson18@gmail.com", "2kegs");
			System.Console.WriteLine(authenticated);
		}
	}
}
