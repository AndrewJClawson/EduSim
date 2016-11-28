using System;
using EduSim.Core.Constants;
using EduSim.Core.Models;
using EduSim.Core.Services;
namespace EduSim.Web.ViewModels
{
	public class ViewModelFactory
	{
		public static SystemAccountsViewModel CreateSystemAccountsListViewModel(IAccountService accountService)
		{
			SystemAccountsViewModel systemAccountsVM = new SystemAccountsViewModel()
			{
				AccountList = accountService.GetAll()
			};
			return systemAccountsVM;
		}

		public static AccountDetailsViewModel CreateAccountDetailsViewModel(IAccountService accountService, ILookupService lookupService, int accountId)
		{
			AccountDetailsViewModel accountDetailsVM = new AccountDetailsViewModel();
			if (accountId != 0)
			{
				
				accountDetailsVM.AccountId = accountId;
				accountDetailsVM.Account = accountService.GetById(accountId);


			}
			accountDetailsVM.AccountTypeList = lookupService.GetAccountTypes();

			return accountDetailsVM;
		}
	}
}
