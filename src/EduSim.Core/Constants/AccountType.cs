using System;
namespace EduSim.Core.Constants
{
	public class AccountType
	{
		public static Constant District
		{
			get { return new Constant() { Id = 1, Name = "District" }; }
		}

		public static Constant School
		{
			get { return new Constant() { Id = 2, Name = "School" }; }
		}

		public static Constant Homeschool
		{
			get { return new Constant() { Id = 3, Name = "Homeschool" }; }
		}
	}
}