using EduSim.Core.Contexts;
using EduSim.Core.Models;
using EduSim.Core.ModelInterfaces;
using EduSim.Core.Services.Abstractions;

using System;
using System.Collections.Generic;

namespace EduSim.Web.Services
{
	public class AccountService : IAccountService
	{
		private IEduSimContext _eduSimContext;

		public AccountService(IEduSimContext eduSimContext)
		{
			
			_eduSimContext = eduSimContext;
		}

		public IEnumerable<AccountType> GetAccountTypes()
		{
			return (IEnumerable<AccountType>)_eduSimContext.AccountTypes;
		}

		public IEnumerable<Account> GetAccounts()
		{
			return null;
		}

		public Account GetAccountById(int accountId)
		{
			return null;
		}
	}
}
