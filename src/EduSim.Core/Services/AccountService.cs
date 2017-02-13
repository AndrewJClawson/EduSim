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
	public class AccountService : IAccountService
	{
		// - Member variables
		//private readonly Repository<Account> _accountRepository;
		EduSimContext _context;
		// - Constructor
		public AccountService(EduSimContext context)
		{
			_context = context;
			//_accountRepository = new Repository<Account>();
		}

		// Dependency Injection constructor
		//public AccountService(DbContext db)
		//{
		//	//_accountRepository = new Repository<Account>(db);
		//}


		// CRUD Operations
		public void Create(string name, int typeId)
		{
			Account newAccount = new Account() { AccountName = name, AccountTypeId = typeId };
			_context.Accounts.Add(newAccount);
			_context.SaveChanges();
			//_accountRepository.Add(new Account { AccountName = name, AccountTypeId = typeId });
		}

		public void Delete(Account account)
		{
			if (account != null)
			{
				_context.Entry(account).State = EntityState.Deleted;
				_context.Accounts.Attach(account);
				_context.Accounts.Remove(account);
				_context.SaveChanges();
			}
			//_accountRepository.Delete(account);
		}

		public void Delete(int id)
		{
			Account deleteAccount = _context.Accounts.Find(id);
			if (deleteAccount != null)
			{
				_context.Entry(deleteAccount).State = EntityState.Deleted;
				_context.Accounts.Attach(deleteAccount);
				_context.Accounts.Remove(deleteAccount);
				_context.SaveChanges();
			}
		}

		public IEnumerable<Account> GetAccounts()
		{
			List<Account> accounts = _context.Accounts.ToList();

			return accounts;
		}

		public Account GetById(int id)
		{
			Account account = _context.Accounts.Find(id);
			return account;
		}

		public void Update(Account account)
		{
			_context.Accounts.Attach(account);
			_context.Entry(account).State = EntityState.Modified;
			_context.SaveChanges();
		}

		public IEnumerable<AccountType> GetAccountTypes()
		{
			return _context.AccountTypes;
		}
	}
}