using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;
using System.Security;

namespace EduSim.Core.Models
{
	[Table("_roles")]
	public class Role : IRole
	{
		[Column("pk_role_id")]
		public int RoleId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public virtual ICollection<RolePermission> Permissions { get; set; }

		public Role()
		{
		}
	}
}
