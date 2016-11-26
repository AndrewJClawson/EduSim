using System;
namespace EduSim.Core.ModelInterfaces
{
	public interface IPermission
	{
		int PermissionId { get; set; }
		int ContentTypeOperationId { get; set; }
		string Name { get; set; }
	}
}
