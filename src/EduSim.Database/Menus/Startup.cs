using System;
using System.Collections.Generic;

namespace EduSim.Database.Menus
{
	public class Startup : BaseMenu
	{
		public Startup()
		{
			Title = "Start Menu";
			MenuOptions = new List<IMenuOption>();

			MenuOptions.Add(new BackupDatabase(){OptionNumber = 1});

		}


	}
}
