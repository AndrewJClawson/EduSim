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

		static void Main()
		{
			List<Account> accounts = _accountService.GetAll();

			foreach (Account account in accounts)
			{
				System.Console.WriteLine(account.AccountName);
			}

			System.Console.WriteLine("\n");
			_accountService.Create("New Test Account", Constants.AccountType.Homeschool.Id);

			accounts = _accountService.GetAll();
			foreach(Account account in accounts)
			{
				System.Console.WriteLine(account.AccountName);
			}

			using (EduSimContext edContext = new EduSimContext())
			{
				var users = edContext.Users.ToList();
				foreach (User user in users)
				{
					System.Console.WriteLine(user.FirstName);
				}
			}
		}
	}
}

