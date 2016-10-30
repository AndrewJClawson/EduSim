using System;
using System.Data.Entity;
//using MySql.Data.Entity;
using EduSim.Core.Models;
using EduSim.Core.ModelInterfaces;
using EduSim.Core.Models.Identity;

namespace EduSim.Core.Contexts
{
	public interface IEduSimContext
	{
		DbSet<AccountType> AccountTypes { get; set;}
		DbSet<Account> Accounts { get; set;}
		DbSet<User> Users { get; set; }
		DbSet<School> Schools { get; set; }
	}
}