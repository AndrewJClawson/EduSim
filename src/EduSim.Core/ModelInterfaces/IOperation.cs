using System;
namespace EduSim.Core.ModelInterfaces
{
	public interface IOperation
	{
		int OperationId { get; set; }
		string Name { get; set; }
	}
}
