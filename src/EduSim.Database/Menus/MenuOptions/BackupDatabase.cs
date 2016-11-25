using System;
namespace EduSim.Database.Menus
{
	public class BackupDatabase : IMenuOption
	{
		public int OptionNumber { get; set;}
		public string Name { get; set; }
		public BackupDatabase()
		{
			this.Name = "Backup Database";
		}

		public void OnSelect()
		{
			System.Console.WriteLine("You selected to backup the databse.");
		}
	}
}
