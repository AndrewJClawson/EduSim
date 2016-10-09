using System;
using EduSim.Core.Models;
using EduSim.Core.Contexts;
using System.Linq;
using System.Data;
using System.Data.Entity;

namespace EduSim.Sandbox
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			using(var context = new EduSimContext())
			{
				foreach(AccountType type in context.AccountTypes.ToList())
				{
					System.Console.WriteLine(type.Name);
				}
			}
		}
	}
}
