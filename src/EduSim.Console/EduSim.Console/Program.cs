using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using EduSim.Models;

using EduSim.Contexts;

namespace EduSim.Console
{
	class MainClass
	{
		static void Main()
		{
			using (EduSimContext context = new EduSimContext())
			{
				var accounts = context.Accounts.ToList();
				foreach (Account account in accounts)
				{
					System.Console.WriteLine(account.AccountName);
				}
			}

		}
	}
}

