using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("accounts")]
	public class Account : IAccount
	{
		[Column("pk_account_id")]
		public int AccountId { get; set; }

		[Column("fk_account_type_id")]
		public int AccountTypeId { get; set; }

		[Column("account_name")]
		public string AccountName { get; set; }

		public virtual ICollection<User> Users { get; set; }

		public Account()
		{
		}
	}
}
