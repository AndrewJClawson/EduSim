using System;
using EduSim.Models;
namespace EduSim.Core.ModelInterfaces
{
	public class IContentTypeOperation
	{
		int ContentTypeOperationId { get; set; }
		int ContentTypeId { get; set; }
		int OperationId { get; set; }
	}
}
