using EduSim.Core.Constants;
using EduSim.Core.Contexts;
using EduSim.Core.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace EduSim.Core.Services
{
	public class PermissionService : IPermissionService
	{
		EduSimContext _context;

		public PermissionService(EduSimContext context)
		{
			_context = context;
		}

		public IEnumerable<Role> GetRoles()
		{
			return _context.Roles;
		}

		public Role GetRoleById(int id)
		{
			return _context.Roles.Where(r => r.RoleId == id).FirstOrDefault();
		}

		public IEnumerable<Models.ContentType> GetContentTypes()
		{
			return _context.ContentTypes;
		}

		public Models.ContentType GetContentTypeById(int id)
		{
			return _context.ContentTypes.Where(t => t.ContentTypeId == id).FirstOrDefault();
		}

		public IEnumerable<Models.Operation> GetOperations()
		{
			return _context.Operations;
		}

		public Models.Operation GetOperationById(int id)
		{
			return _context.Operations.Where(o => o.OperationId == id).FirstOrDefault();
		}

		public IEnumerable<Models.Permission> GetPermissions()
		{
			return _context.Permissions;
		}

		public Models.Permission GetPermissionById(int id)
		{
			return _context.Permissions.Where(p => p.PermissionId == id).FirstOrDefault();
		}

		public Models.Permission GetPermission(int contentTypeId, int operationId)
		{
			return _context.Permissions.Where(p => ;
		}
	}
}
