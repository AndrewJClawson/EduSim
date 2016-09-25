using System;
using System.Data.Entity;
//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.Entity;
using EduSim.ModelInterfaces;

namespace EduSim.Models
{
	[Table("_account_types")]
	public class AccountType
	{
		[Column("pk_account_type_id")]
		public int id { get; set;}
		public string Name { get; set; }
		public AccountType()
		{
		}
	}
}
