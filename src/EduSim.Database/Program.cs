using System;
using EduSim.Database.Menus;

namespace EduSim.Database
{
	class MainClass
	{
		//public static Startup StartMenu { get; set;}

		public static void Main(string[] args)
		{
			System.Console.WriteLine("Hello World! This is the EduSim Database project!");
			Startup StartMenu = new Startup();
			Console.WriteLine("Select an option from the menu below: ");

			StartMenu.DisplayMenu();

			StartMenu.Input = Console.ReadLine();
			int selectedOption = int.Parse(StartMenu.Input);
			StartMenu.MenuOptions[selectedOption - 1].OnSelect();



		}


	}
}
