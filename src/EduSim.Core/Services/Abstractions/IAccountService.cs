using EduSim.Core.Models;
using System;
using System.Collections.Generic;

namespace EduSim.Core.Services
{
	public interface IAccountService
	{
		IEnumerable<AccountType> GetAccountTypes();
		IEnumerable<Account> GetAccounts();
		Account GetById(int accountId);
		void Update(Account account);
	}
}
