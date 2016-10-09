using System;
using System.Linq;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.Contexts;
using EduSim.Core.Repository;
using System.Data.Entity;

using MySql.Data.Entity;

namespace EduSim.Core.Services
{
	public class AccountService
	{
		// - Member variables
		private readonly Repository<Account> _accountRepository;

		// - Constructor
		public AccountService()
		{
			_accountRepository = new Repository<Account>();
		}

		// Dependency Injection constructor
		public AccountService(DbContext db)
		{
			_accountRepository = new Repository<Account>(db);
		}


		// CRUD Operations
		public void Create(string name, int typeId)
		{
			_accountRepository.Add(new Account { AccountName = name, AccountTypeId = typeId });
		}

		public void Delete(Account account)
		{
			_accountRepository.Delete(account);
		}

		public void Delete(int id)
		{
			_accountRepository.Delete(id);
		}

		public List<Account> GetAll()
		{
			List<Account> accounts = _accountRepository.GetAll().ToList();

			return accounts;
		}

		public Account GetById(int id)
		{
			Account returnAccount = _accountRepository.GetById(id);
			return returnAccount;
		}

		public void Update(Account account)
		{
			_accountRepository.Update(account);
		}
	}
}