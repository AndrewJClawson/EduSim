using System;
namespace EduSim.Core.Constants
{
	public class Role
	{
		public static Constant SystemAdmin
		{
			get { return new Constant() { Id = 1, Name = "System Admin" }; }
		}

		public static Constant AccountAdmin
		{
			get { return new Constant() { Id = 2, Name = "Account Admin" }; }
		}

		public static Constant SchoolAdmin
		{
			get { return new Constant() { Id = 3, Name = "School Admin" };}
		}

		public static Constant Instructor
		{
			get { return new Constant() { Id = 4, Name = "Instructor" }; }
		}
	}
}
