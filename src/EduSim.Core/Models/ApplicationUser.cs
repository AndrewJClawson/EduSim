using System;
namespace EduSim.Core.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ApplicationUser()
		{
			public virtual string FirstName { get; set; }
			public virtual string LastName { get; set; }
			public virtual bool IsAdmin { get; set; }
			public virtual bool IsInstructor { get; set; }
			public virtual bool IsVolunteer { get; set; }
		}
	}
}
