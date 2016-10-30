using System;
using System.Data.Entity;
using MySql.Data.Entity;
using EduSim.Core.Models;
using EduSim.Core.Models.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace EduSim.Core.Contexts
{
	[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
	public partial class EduSimContext : IdentityDbContext<Microsoft.AspNet.Identity.EntityFramework.IdentityUser>, IEduSimContext
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
