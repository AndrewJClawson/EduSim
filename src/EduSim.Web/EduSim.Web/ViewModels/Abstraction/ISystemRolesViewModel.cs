using System;
using System.Collections.Generic;
using EduSim.Core.ModelInterfaces;
using EduSim.Core.Models;

namespace EduSim.Web.ViewModels
{
	public interface ISystemRolesViewModel
	{
		List<Role> Roles { get; set; }
	}
}
