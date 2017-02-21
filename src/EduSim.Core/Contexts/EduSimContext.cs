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
		// Look up models
		public DbSet<AccountType> AccountTypes { get; set; }
		public DbSet<ContentType> ContentTypes { get; set; }
		public DbSet<Operation> Operations { get; set; }

		public DbSet<Permission> Permissions { get; set; }
		public DbSet<ProfilePermission> ProfilePermissions { get; set; }

		public DbSet<Role> Roles { get; set; }

		// Application API models
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Profile> Profiles { get; set;}
		public DbSet<School> Schools { get; set; }



		public EduSimContext() : base(nameOrConnectionString:"EduSimContext")
		{
			
		}

		protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		} 
	}
}
