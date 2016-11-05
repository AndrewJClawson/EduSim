using System;
using System.Data.Entity;
using MySql.Data.Entity;
using EduSim.Core.ModelInterfaces;
using EduSim.Core.Models;
//using EduSim.Core.Models.Identity;



namespace EduSim.Core.Contexts
{
	[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
	public partial class EduSimContext : DbContext, IEduSimContext
	{
		public DbSet<AccountType> AccountTypes { get; set; }
		public DbSet<Account> Accounts { get; set; }
		//public DbSet<IdentityUser> IdentityUsers { get; set; }
		public DbSet<User> Users { get; set;}
		public DbSet<School> Schools { get; set; }

		public EduSimContext() : base(nameOrConnectionString:"EduSimContext")
		{
			
		}
	}
}
