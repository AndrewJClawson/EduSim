using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;
            	
namespace EduSim.Core.Models
{
	[Table("_account_types")]
	public class AccountType : IAccountType
	{
		[Column("pk_account_type_id")]
		public int AccountTypeId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public AccountType()
		{
			
		}
	}
}
