using EduSim.Core.ModelInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EduSim.Core.Models
{
	[Table("_operations")]
	public class Operation : IOperation
	{
		[Column("pk_operation_id")]
		public int OperationId { get; set; }

		[Column("name")]
		public string Name { get; set; }
	}
}
