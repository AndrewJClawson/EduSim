using System;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	public class ContentTypeOperation : IContentTypeOperation
	{
		public int ContentTypeOperationId { get; set; }
		public int ContentTypeId { get; set; }
		public int OperationId { get; set; }

		public virtual ContentType ContentType { get; set; }
		public virtual Operation Operation { get; set; }

	}
}
