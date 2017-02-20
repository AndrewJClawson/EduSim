using System;
using EduSim.Core.Models;
namespace EduSim.Core.ModelInterfaces
{
	public class IPermission
	{
		int PermissionId { get; set; }
		int ContentTypeId { get; set; }
		int OperationId { get; set; }
	}
}
