using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using EduSim.Constants;
using EduSim.Models;
using EduSim.Contexts;
using EduSim.Repository;
using EduSim.Services;

namespace EduSim.Console
{
	class MainClass
	{
		private static AccountService _accountService = new AccountService();
		private static UserService _userService = new UserService();
		static void Main()
		{
			List<Account> accounts = _accountService.GetAll();

			foreach (Account account in accounts)
			{
				System.Console.WriteLine("Account Name: ");

				System.Console.WriteLine(account.AccountName);
				System.Console.WriteLine("");
				System.Console.WriteLine("User List: ");

				foreach(User user in account.Users)
				{
					System.Console.WriteLine(user.FirstName + " " + user.LastName);
				}
				System.Console.WriteLine("");
			}

		}
	}
}

