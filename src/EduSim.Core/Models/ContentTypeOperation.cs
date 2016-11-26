using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("_content_type_operations")]
	public class ContentTypeOperation : IContentTypeOperation
	{
		[Column("pk_content_type_operation_id")]
		public int ContentTypeOperationId { get; set; }

		[Column("fk_content_type_id")]
		public int ContentTypeId { get; set; }

		[Column("fk_operation_id")]
		public int OperationId { get; set; }

		public virtual ContentType ContentType { get; set; }
		public virtual Operation Operation { get; set; }

	}
}
