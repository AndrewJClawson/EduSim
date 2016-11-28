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

		public static AccountDetailsViewModel CreateAccountDetailsViewModel(IAccountService accountService, ILookupService lookupService, int? accountId)
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

			accountDetailsVM.AccountTypeList = lookupService.GetAccountTypes();

			return accountDetailsVM;
		}
	}
}
