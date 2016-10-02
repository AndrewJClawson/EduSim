using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using EduSim.Models;
using EduSim.Contexts;
using EduSim.Repository;

namespace EduSim.Console
{
	class MainClass
	{
		private static Repository<Account> _accountRepository = new Repository<Account>();
		private static Repository<AccountType> _accountTypeRepository = new Repository<AccountType>();
		static void Main()
		{
			var accountList = _accountRepository.GetAll().ToList();
			foreach (Account account in accountList)
			{
				System.Console.WriteLine(account.AccountName);
			}

			var accountTypeList = _accountTypeRepository.GetAll();
			foreach (AccountType type in accountTypeList)
			{
				System.Console.WriteLine(type.Name);
			}



		}
	}
}

