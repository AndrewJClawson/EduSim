using System;
using EduSim.Core.Constants;
using EduSim.Core.Models;
using EduSim.Core.Services;
using System.Collections.Generic;
using System.Linq;

namespace EduSim.Web.ViewModels
{
	public class ViewModelFactory
	{
		public static SystemAccountsViewModel CreateSystemAccountsListViewModel(IAccountService accountService)
		{
			SystemAccountsViewModel systemAccountsVM = new SystemAccountsViewModel()
			{
				AccountList = accountService.GetAccounts().ToList()
		};
			return systemAccountsVM;
		}

		public static AccountDetailsViewModel CreateAccountDetailsViewModel(IAccountService accountService, int? accountId)
		{
			AccountDetailsViewModel accountDetailsVM = new AccountDetailsViewModel();
			if (accountId != null)
			{

				accountDetailsVM.AccountId = accountId;
				accountDetailsVM.Account = accountService.GetById((int)accountId);


			}
			else
			{
				accountDetailsVM.AccountId = EduSim.Core.Constants.Account.NewAccount.Id;
				accountDetailsVM.Account = new EduSim.Core.Models.Account()
				{
					AccountName = string.Empty,

				};
			}

			accountDetailsVM.AccountTypeList = accountService.GetAccountTypes().ToList();

			return accountDetailsVM;
		}
	}
}
