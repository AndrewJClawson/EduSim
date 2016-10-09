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
		public static void Main(string[] args)
		{
			List<Account> accounts = _accountService.GetAll().ToList();
			foreach(Account account in accounts)
			{
				System.Console.WriteLine(account.AccountName);
			}
		}
	}
}
