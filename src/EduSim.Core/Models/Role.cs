using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;
using System.Security;

namespace EduSim.Core.Models
{
	[Table("roles")]
	public class Role : IRole
	{
		[Column("pk_role_id")]
		public int RoleId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public Role()
		{
		}
	}
}
