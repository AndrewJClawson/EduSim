using System;
using System.Data.Entity;
using System.Data.Linq;
using MySql.Data.Entity;

using EduSim.Models;

namespace EduSim.Contexts
{
	public partial class EduSimContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; }
		public DbSet<User> Users {get;set;}
		public DbSet<AccountType> AccountTypes { get; set;}

		public EduSimContext()  : base(nameOrConnectionString: "EduSimContext")
		{
			
		}
	}
}
