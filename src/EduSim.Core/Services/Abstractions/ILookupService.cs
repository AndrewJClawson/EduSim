using System;
using System.Collections.Generic;
using EduSim.Core.Models;
namespace EduSim.Core.Services
{
	public interface ILookupService
	{
		List<AccountType> GetAccountTypes();
		AccountType GetAccountType(string accountTypeName);

		List<Role> GetRoles();
		Role GetRole(string roleName);	
	}
}
