using System;
using EduSim.Core.Constants;

namespace EduSim.Core.Contants
{
	public class Account
	{
		public static Constant NewAccount
		{
			get { return new Constant() { Id = 0, Name = "New Account" }; }
		}
	}
}
