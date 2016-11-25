using System;
namespace EduSim.Database.Menus
{
	public interface IMenuOption
	{
		int OptionNumber { get; set;}
		string Name { get; set; }

		void OnSelect();
	}
}
