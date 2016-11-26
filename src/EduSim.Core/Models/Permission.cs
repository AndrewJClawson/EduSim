using EduSim.Core.ModelInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSim.Core.Models
{
	[Table("_permissions")]
	public class Permission : IPermission
	{
		[Column("pk_permission_id")]
		public int PermissionId { get; set; }

		[Column("fk_content_type_operation_id")]
		public int ContentTypeOperationId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public virtual ContentTypeOperation ContentTypeOperation {get;set;}
	}
}
