using EduSim.Core.ModelInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSim.Core.Models
{
	[Table("profile_permissions")]
	public class ProfilePermission : IProfilePermission
	{
		[Column("pk_profile_permission_id")]
		public int ProfilePermissionId { get; set; }

		[Column("fk_profile_id")]
		public int ProfileId { get; set; }

		[Column("fk_permission_id")]
		public int PermissionId { get; set; }

		public virtual Profile Profile { get; set; }

		public virtual Permission Permission { get; set; }
	}
}
