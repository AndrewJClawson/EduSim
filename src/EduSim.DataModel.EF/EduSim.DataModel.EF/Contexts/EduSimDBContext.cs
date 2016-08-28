using System;
using System.Data.Entity;
using System.Linq;
using System.Data.Linq.Mapping;
using MySql.Data.Entity;


namespace EduSim.Database
{
	public class EduSimDBContext : DbContext, IApplicationDBContext
	{
		public EduSimDBContext() : base(nameOrConnectionString: "DevelopDBContext") { }
		//public DbSet<Account> AccountList { get; set; }
		//public DbSet<School> SchoolList { get; set; }
		//public DbSet<User> UserList { get; set; }

		/*
		public void MarkAsModified(Account account)
		{
			Entry(account).State = EntityState.Modified;
		}
		*/

		//Overloaded for User type.
		//public void MarkAsModified(User user)
		//{
		//	Entry(user).State = EntityState.Modified;
		//}

		public override System.Threading.Tasks.Task<int> SaveChangesAsync()
		{
			return base.SaveChangesAsync();

		}
	}

}


