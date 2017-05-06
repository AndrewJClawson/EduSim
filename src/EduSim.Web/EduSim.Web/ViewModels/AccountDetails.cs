using System;
using EduSim.Core.Models;

namespace EduSim.Web.ViewModels
{
	public class AccountDetails
	{
		public int AccountId { get; set; }
		public int AccountTypeId { get; set; }
		public int AccountList { get; set; }
		public string Name { get; set; }

		public AccountDetails(Account account)
		{
			AccountId = account.AccountId;
			Name = account.AccountName;
			AccountTypeId = account.AccountTypeId;
		}
	}
}
