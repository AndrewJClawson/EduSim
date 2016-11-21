using System;
using System.Collections.Generic;
using EduSim.Core.Models;
namespace EduSim.Web.ViewModels
{
	public class SystemRolesViewModel : ISystemRolesViewModel
	{
		public List<Role> Roles { get; set; }
		public SystemRolesViewModel()
		{
			
		}
	}
}
