using System;
using System.Data.Linq.Mapping;
using EduSim.ModelInterfaces;

namespace EduSim
{
	public class SyncColumns : ISyncColumns
	{
		

		public SyncColumns()
		{
		}

		public SyncColumns(SyncColumns src)
		{
			CreatedUserId = src.CreatedUserId;
		}

		[Column(Name="fk_created_user_id")]
		public int CreatedUserId { get; set; }

		[Column(Name = "created_timestamp")]
		public DateTime CreatedTimestamp { get; set;}

		[Column(Name = "fk_updated_user_id")]
		public int? UpdatedUserId { get; set;}

		[Column(Name = "updated_timestamp")]
		public DateTime? UpdatedTimestamp { get; set;}
	}
}

