using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("profiles_x_roles")]
	public class ProfileRole : IProfileRole
	{
		[Column("fk_profile_id")]
		public int ProfileId { get; set; }

		[Column("fk_role_id")]
		public int RoleId { get; set; }

		public ProfileRole()
		{
		}
	}
}
