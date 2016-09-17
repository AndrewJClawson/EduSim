using System;
namespace EduSim.ModelInterfaces
{
	public interface IAccount : ISyncColumns
	{
		int AccountId { get; set; }
		string AccountName { get; set; }
		int AccountTypeId { get; set; }
	}
}

