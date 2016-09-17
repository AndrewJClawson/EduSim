using System;
namespace EduSim.ModelInterfaces
{
	public interface ISyncColumns
	{
		int CreatedUserId { get; set;}
		int? UpdatedUserId { get; set;}
		DateTime CreatedTimestamp { get; set; }
		DateTime? UpdatedTimestamp { get; set; }
	}
}

