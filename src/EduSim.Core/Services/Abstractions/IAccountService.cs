using EduSim.Core.Models;
using System;
using System.Collections.Generic;

namespace EduSim.Core.Services.Abstractions
{
	public interface IAccountService
	{
		IEnumerable<AccountType> GetAccountTypes();
		IEnumerable<Account> GetAccounts();
		Account GetAccountById(int accountId);
	}
}
