using EduSim.Core.ModelInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSim.Core.Models
{
	[Table("_content_types")]
	public class ContentType : IContentType
	{
		[Column("pk_content_type_id")]
		public int ContentTypeId { get; set; }

		[Column("name")]
		public string Name { get; set; }

	}
}
