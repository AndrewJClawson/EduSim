using System;
namespace EduSim.Core
{
	public interface IProfilePermission
	{
		int ProfilePermissionId { get; set; }
		int ProfileId { get; set; }
		int PermissionId { get; set; }
	}
}
