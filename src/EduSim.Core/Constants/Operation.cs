using System;
namespace EduSim.Core.Constants
{
	public class Operation
	{
		public static Constant Create
		{
			get { return new Constant() { Id = 1, Name = "Create" };  }
		}

		public static Constant View
		{
			get { return new Constant() { Id = 2, Name = "View" }; }
		}

		public static Constant Edit
		{
			get { return new Constant() { Id = 3, Name = "Edit" }; }
		}

		public static Constant Delete
		{
			get { return new Constant() { Id = 4, Name = "Delete" }; }
		}
	}
}
