using System;
using System.Collections.Generic;
namespace EduSim.Database.Menus
{
	public interface IMenu
	{
		List<IMenuOption> MenuOptions { get; set; }
		string Title { get; set; }
		string Input { get; set; }
		void DisplayMenu();
		void DisplayMenuOptions();
	}
}
