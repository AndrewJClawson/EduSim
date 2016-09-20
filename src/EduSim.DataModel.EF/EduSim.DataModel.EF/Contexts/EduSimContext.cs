using System;
using System.Data.Entity;
using EduSim.Models;

namespace EduSim.DataModel.EF
{
	public partial class EduSimContext : DbContext
	{
		public DbSet<User> Users {get;set;}

		public EduSimContext() : base(nameOrConnectionString: "LocalDBContext")
		{
			
		}
	}
}
