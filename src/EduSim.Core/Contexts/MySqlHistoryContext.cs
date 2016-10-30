using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace EduSim.Core.Contexts
{
	public class MySqlHistoryContext : HistoryContext
	{
		public MySqlHistoryContext(DbConnection existingConnection)
		{
			
		}
	}
}
