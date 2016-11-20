using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;
using System.Security;

namespace EduSim.Core.Models
{
	[Table("roles")]
	public class Role
	{
		public int RoldId { get; set; }
		public string Name { get; set; }

		public Role()
		{
		}
	}
}
