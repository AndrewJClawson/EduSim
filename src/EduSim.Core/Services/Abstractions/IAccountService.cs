using System;
using System.Collections.Generic;
using EduSim.Core.Models;

namespace EduSim.Core.Services
{
	public interface IAccountService
	{
		void Create(string name, int typeId);
		void Delete(Account account);
		void Delete(int id);
		IEnumerable<Account> GetAccounts();
		IEnumerable<AccountType> GetAccountTypes();
		Account GetById(int id);
		void Update(Account accont);
	}
}
