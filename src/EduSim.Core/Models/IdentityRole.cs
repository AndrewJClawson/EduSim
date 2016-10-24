using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EduSim.Core
{
	[Table("user_roles")]
	public class IdentityRole : IRole
	{
		public IdentityRole()
		{
			Id = Guid.NewGuid().ToString();
		}

		public IdentityRole(string name) : this()
		{
			Name = name;
		}

		public IdentityRole(string name, string id) : this()
		{
			Id = id;
			Name = name;
		}

		[Column("pk_role_id")]
		public string Id { get; set; }

		[Column("name")]
		public string Name { get; set; }
	}
}
