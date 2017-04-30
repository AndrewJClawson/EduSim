using EduSim.Core.ModelInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EduSim.Core.Models
{
	[Table("roles_x_permissions")]
	public class RolePermission : IRolePermission
	{
		[Column("fk_role_id"), ForeignKey("Role")]
		public int RoleId { get; set; }


		[Column("fk_permission_id"), ForeignKey("Permission")]
		public int PermissionId { get; set; }


		public virtual Role Role { get; set; }


		public virtual Permission Permission { get; set; }
	}
}
