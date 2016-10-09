using System;
using System.Data.Entity;
using MySql.Data.Entity;
using EduSim.Core.Models;

namespace EduSim.Core.Contexts
{
	public partial class EduSimContext : DbContext
	{
		public DbSet<AccountType> AccountTypes { get; set; }
		public DbSet<Account> Accounts { get; set; }
		public DbSet<User> Users { get; set; }

		public EduSimContext() : base(nameOrConnectionString:"EduSimContext")
		{
		}
	}
}
