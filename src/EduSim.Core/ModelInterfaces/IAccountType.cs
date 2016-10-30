using System;
using System.ComponentModel;

namespace EduSim.Core.ModelInterfaces
{
	
	public interface IAccountType
	{
		int AccountTypeId { get; set; }
		string Name { get; set; }
	}
}
