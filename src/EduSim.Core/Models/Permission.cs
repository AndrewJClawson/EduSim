using EduSim.Core.ModelInterfaces;
using System;
namespace EduSim.Core.Models
{
	public class Permission : IPermission
	{
		public int PermissionId { get; set; }
		public int ContentTypeOperationId { get; set; }
		public string Name { get; set; }

		public virtual ContentTypeOperation ContentTypeOperation {get;set;}
	}
}
