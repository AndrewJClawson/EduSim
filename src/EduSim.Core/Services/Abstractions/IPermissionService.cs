using EduSim.Core.Contexts;
using EduSim.Core.Models;
using System;
using System.Collections.Generic;

namespace EduSim.Core.Services
{
	public interface IPermissionService
	{
		IEnumerable<Role> GetRoles();
		Role GetRoleById(int id);

		IEnumerable<ContentType> GetContentTypes();
		ContentType GetContentTypeById(int id);

		IEnumerable<Operation> GetOperations();
		Operation GetOperationById(int id);

		IEnumerable<Permission> GetPermissions();
		Permission GetPermissionById(int id);
		Permission GetPermission(int contentTypeId, int operationId);
	}
}
