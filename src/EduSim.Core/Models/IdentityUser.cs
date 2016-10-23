using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EduSim.Core.Models
{
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

		public string Id {get;set;}

		public string UserName {get;set;}

		public virtual string Email {get;set;}

		public virtual bool EmailConfirmed {get;set;}

		public virtual string PasswordHash {get;set;}

		public virtual string SecurityStamp {get;set;}

		public virtual string PhoneNumber {get;set;}

		public virtual bool PhoneNumberConfirmed {get;set;}

		public virtual bool TwoFactorEnabled {get;set;}

		public virtual DateTime? LockoutEndDateUtc {get;set;}

		public virtual int AccessFailedCount {get;set;}
}
