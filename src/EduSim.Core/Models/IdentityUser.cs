using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;

namespace EduSim.Core.Models
{
	[Table("identity_users")]
	public class IdentityUser : IUser
	{
		public IdentityUser()
		{
			Id = Guid.NewGuid().ToString();
		}

		public IdentityUser(string username) : this()
		{
			UserName = username;
		}

		[Column("pk_identity_user_id")]
		public string Id { get; set; }

		[Column("username")]
		public string UserName { get; set; }

		[Column("email")]
		public virtual string Email { get; set; }

		[Column("email_confirmed")]
		public virtual bool EmailConfirmed { get; set; }

		[Column("password_hash")]
		public virtual string PasswordHash { get; set; }

		[Column("security_stamp")]
		public virtual string SecurityStamp { get; set; }

		[Column("phone_number")]
		public virtual string PhoneNumber { get; set; }

		[Column("phone_number_confirmed")]
		public virtual bool PhoneNumberConfirmed { get; set; }

		[Column("two_factor_enabled")]
		public virtual bool TwoFactorEnabled { get; set; }

		[Column("locout_end_date_utc")]
		public virtual DateTime? LockoutEndDateUtc { get; set; }

		[Column("access_failed_count")]
		public virtual int AccessFailedCount { get; set; }
	}

	public class ApplicationUser : IdentityUser
	{
		
	}
}
