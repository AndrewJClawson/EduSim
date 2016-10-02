using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.Entity;
using EduSim.ModelInterfaces;

namespace EduSim.Models
{
	[Table("accounts")]
	public class Account
	{
		[Column("pk_account_id")]
		public int AccountId { get; set;}

		[Column("fk_account_type_id")]
		public int AccountTypeId { get; set;}

		[Column("account_name")]
		public string AccountName { get; set;}



	}
}

