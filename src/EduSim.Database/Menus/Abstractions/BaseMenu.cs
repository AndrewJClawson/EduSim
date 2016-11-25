using System;
using System.Collections.Generic;
namespace EduSim.Database.Menus
{
	public class BaseMenu : IMenu
	{
		public List<IMenuOption> MenuOptions { get; set; }
		public string Title { get; set; }
		public string Input { get; set; }
		public BaseMenu()
		{
		}

		public void DisplayMenu()
		{
			System.Console.WriteLine(this.Title);
			DisplayMenuOptions();
		}
		public void DisplayMenuOptions()
		{
			foreach(var option in MenuOptions)
			{
				System.Console.WriteLine(option.OptionNumber.ToString() + ": " + option.Name);
			}
		}
	}
}
