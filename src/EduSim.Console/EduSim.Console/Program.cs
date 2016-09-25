using System;
using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using EduSim.Models;
using EduSim.DataModel.EF;
using EduSim.Contexts;

namespace EduSim.Console
{
	class MainClass
	{
		static void Main()
		{
			using (EduSimContext context = new EduSimContext())
			{
				foreach(AccountType type in context.AccountTypes)
				{
					System.Console.WriteLine(type.Name);
				}
			}

		}
	}
}

