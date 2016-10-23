using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EduSim.Core.Models
{
	public class IdentityUser : IUser
	{
		public virtual string Email { get; set; }

		public virtual bool EmailConfirtmed { get; set; }

		public virtual string Id { get; set;}

		public virtual bool LockoutEnabled { get; set; }

		public virtual DateTime? LockoutEndDateUtc { get; set; }

		public virtual ICollection<IdentityUserLogin> Logins { get; set; }

		public virtual string PasswordHash { get; set; }

		public virtual string PhoneNumber { get; set; }

		public virtual bool PhoneNumberConfirmed { get; set; }

		public virtual ICollection<IdentityUserRole> Roles { get; set; }

		public virtual string SecutityStamp { get; set; }

		public virtual bool TwoFactorEnabled { get; set; }

		public virtual string UserName { get; set; }

	}
}
