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
			List<Account> accounts = _accountService.GetAll().ToList();
			List<User> users = _userService.GetAll().ToList();
			foreach(User user in users)
			{
				System.Console.WriteLine(user.FirstName + " " + user.LastName + ": " + user.School.SchoolName);
			}
		}
	}
}
