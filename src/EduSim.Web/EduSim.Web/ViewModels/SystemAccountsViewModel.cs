using System;
using System.Linq;
using System.Collections.Generic;
using EduSim.Core.Models;
using System.Web.Mvc;

namespace EduSim.Web.ViewModels
{
	public class SystemAccountsViewModel
	{
		public int SelectedAccountId { get; set; }
		public List<Account> AccountList { get; set; }
		public List<AccountType> AccountTypeList { get; set; }
		public int SelectedAccountTypeId { get; set; }
		public IEnumerable<SelectListItem> AccountDropDown
		{
			get
			{
				return new SelectList(AccountList, "AccountId", "AccountName");
			}
		}


	}
}
