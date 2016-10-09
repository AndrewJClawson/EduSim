using System;
using EduSim.Core.Models;

namespace EduSim.Core.ModelInterfaces
{
	public interface ISchool
	{
		int SchoolId { get; set; }
		int AccountId { get; set; }
		string SchoolName { get; set; }
		string Address { get; set; }
		string City { get; set; }
		string State { get; set; }
		string Zip { get; set; }
	}
}
