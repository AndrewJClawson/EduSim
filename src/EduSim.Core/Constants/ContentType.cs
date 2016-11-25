using System;
namespace EduSim.Core.Constants
{
	public class ContentType
	{
		public static Constant Account
		{
			get { return new Constant() { Id = 1, Name = "Account" }; }
		}

		public static Constant User
		{
			get { return new Constant() { Id = 2, Name = "User" }; }
		}

		public static Constant Profile
		{
			get { return new Constant() { Id = 3, Name = "Profile" }; }
		}
	}
}
