using System;

namespace EduSim.Core.Constants
{
	public class Permission
	{
		public static Constant CreateAccounts
		{
			get { return new Constant() { Id = 1, Name = "Can create accounts." }; }
		}

		public static Constant ViewAccounts
		{
			get { return new Constant() { Id = 2, Name = "Can view accounts" }; }

		}

		public static Constant EditAccounts
		{
			get { return new Constant() { Id = 3, Name = "Can edit accounts." }; }
		}

		public static Constant DeleteAccounts
		{
			get { return new Constant() { Id = 4, Name = "Can delete accounts."};}
		}

		public static Constant CreateUsers
		{
			get { return new Constant() { Id = 5, Name = "Can create users." }; }
		}

		public static Constant ViewUsers
		{
			get { return new Constant() { Id = 6, Name = "Can view users."}; }
		}

		public static Constant EditUsers
		{
			get { return new Constant() { Id = 7, Name = "Can edit users."}; }
		}

		public static Constant DeleteUsers
		{
			get { return new Constant() { Id = 8, Name = "Can delete users."}; }
		}

		public static Constant CreateProfiles
		{
			get { return new Constant() { Id = 9, Name = "Can create profiles." }; }
		}

		public static Constant ViewProfiles
		{
			get { return new Constant() { Id = 10, Name = "Can view profiles." }; }
		}

		public static Constant EditProfiles
		{
			get { return new Constant() { Id = 11, Name = "Can edit profiles."}; }
		}

		public static Constant DeleteProfiles
		{
			get { return new Constant() { Id = 12, Name = "Can delete profiles." }; }
		}
	}
}
