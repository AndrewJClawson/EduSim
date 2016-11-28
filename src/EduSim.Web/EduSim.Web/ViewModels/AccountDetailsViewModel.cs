using EduSim.Core.Models;
using EduSim.Core.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EduSim.Web.ViewModels
{
	public class AccountDetailsViewModel
	{
		public int? AccountId { get; set; }
		public int? AccountTypeId { get; set;}
		public Account Account { get; set; }
		public List<AccountType> AccountTypeList { get; set; }

		public IEnumerable<SelectListItem> AccountTypePicker
		{
			get
			{
				return new SelectList(AccountTypeList, "AccountTypeId", "Name");
			}
		}
	}
}
