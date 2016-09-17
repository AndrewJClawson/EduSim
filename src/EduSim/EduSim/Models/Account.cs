using System.Data.Linq.Mapping;

namespace EduSim.Models
{
	[Table(Name="accounts")]
	public class Account
	{
		[Column(IsPrimaryKey = true, Name = "pk_account_id")]
		public int AccountId { get; set;}

		[Column(Name="account_name")]
		public string AccountName { get; set; }

		[Column(Name = "fk_account_type_id")]
		public int AccountTypeId { get; set; }


	}
}

