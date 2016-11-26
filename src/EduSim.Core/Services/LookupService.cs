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
		IRepository<Models.ContentType> _contentTypeRepository;
		IRepository<Models.ProfilePermission> _profilePermissionRepository;

		public LookupService(
			//IRepository<AccountType> accountTypeRepository,
			//IRepository<Role> roleRepository,
			//IRepository<Models.ContentType> contentTypeRepository,
			//IRepository<Models.ProfilePermission> profilePermissionRepository
		)
		{
			this._accountTypeRepository = new Repository<AccountType>();
			this._roleRepository = new Repository<Role>();
			this._contentTypeRepository = new Repository<Models.ContentType>();
			this._profilePermissionRepository = new Repository<Models.ProfilePermission>();
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

		public ProfilePermission GetPermission(string name)
		{
			var permission = _profilePermissionRepository.GetAll()
														 .Where(p => p.Permission.Name == name)
			                                             .FirstOrDefault();
			return permission;
		}
	}
}
