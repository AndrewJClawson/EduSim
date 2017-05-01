using System;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.Contexts;
using EduSim.Core.Constants;
using System.Linq;
using System.Data;
using System.Data.Entity;
using EduSim.Core.Services;
using EduSim.Web;
using EduSim.Web.Models;

namespace EduSim.Sandbox
{
	class MainClass
	{
		//public static AccountService _accountService = new AccountService();
		//public static ProfileService _profileService = new ProfileService();
		public static LookupService _lookupService = new LookupService();


		public static void Main(string[] args)
		{
			using(var context = new EduSimContext())
			{
				
				
			}

		}
	}
}
