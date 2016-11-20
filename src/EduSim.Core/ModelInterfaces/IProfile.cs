using System;

namespace EduSim.Core.ModelInterfaces
{
	public interface IProfile
	{
		string UserId { get; set; }
		int AccountId { get; set; }
		int? SchoolId { get; set; }
		int? CampusId { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string Password { get; set; }
		string IsAdmin { get; set; }
		string IsInstructor { get; set; }
		string IsVolunteer { get; set; }
	}
}
