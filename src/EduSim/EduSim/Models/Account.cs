using System.Data.Entity;
using System.Data.Linq.Mapping;
using MySql.Data.Entity;
using EduSim.ModelInterfaces;

namespace EduSim.Models
{
	[Table(Name="accounts")]
	public class Account : SyncColumns, IAccount
	{
		[Column(Name = "pk_account_id", IsPrimaryKey=true)]
		public int AccountId { get; set;}

		[Column(Name = "fk_account_type_id")]
		public int AccountTypeId { get; set;}

		[Column(Name = "account_name")]
		public string AccountName { get; set;}
	}
}

