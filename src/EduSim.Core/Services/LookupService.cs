using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using EduSim.Core.Constants;
using EduSim.Core.Models;
using EduSim.Core.Repository;

namespace EduSim.Core.Services
{
	public class LookupService : ILookupService
	{
		IRepository<AccountType> _accountTypeRepository;
		IRepository<Role> _roleRepository;

		public LookupService(
			IRepository<AccountType> accountTypeRepository,
			IRepository<Role> roleRepository
		)
		{
			this._accountTypeRepository = accountTypeRepository;
			this._roleRepository = roleRepository;
		}

		public List<Models.AccountType> GetAccountTypes()
		{
			var accountTypes = _accountTypeRepository.GetAll();
			return accountTypes.ToList();
		}

		public AccountType GetAccountType(string accountTypeName)
		{
			var accountType = _accountTypeRepository.GetAll()
													 .Where(t => t.Name == accountTypeName).ToList();
			return accountType.FirstOrDefault();
		}

		public List<Role> GetRoles()
		{
			var roles = _roleRepository.GetAll();
			return roles.ToList();
		}

		public Role GetRole(string rolename)
		{
			var role = _roleRepository.GetAll()
			                          .Where(r => r.Name == rolename).ToList().FirstOrDefault();
			return role;
		}
	}
}
