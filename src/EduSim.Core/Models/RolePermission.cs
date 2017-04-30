using EduSim.Core.ModelInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSim.Core.Models
{
	[Table("role_x_permissions")]
	public class RolePermission : IRolePermission
	{
		[Column("fk_role_id")]
		public int RoleId { get; set; }

		[Column("fk_permission_id")]
		public int PermissionId { get; set; }

		public virtual Profile Profile { get; set; }

		public virtual Permission Permission { get; set; }
	}
}
