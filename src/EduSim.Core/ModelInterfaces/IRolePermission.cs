using System;
namespace EduSim.Core
{
	public interface IRolePermission
	{
		int RoleId { get; set; }
		int PermissionId { get; set; }
	}
}
