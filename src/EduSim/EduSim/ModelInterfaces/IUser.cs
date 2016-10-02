using System;
namespace EduSim
{
	public interface IUser
	{
		int AccountId { get; set; }
		int UserId { get; set; }
		int? SchoolId { get; set;}
		int? CampusId { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string Password { get; set; }
		string IsAdimin { get; set; }
		string IsInstructor { get; set; }
		string IsVolutneer { get; set; }
	}
}
