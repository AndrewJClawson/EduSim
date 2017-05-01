using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Models
{
	[Table("_subjects")]
	public class Subject : ISubject
	{
		[Column("pk_subject_id")]
		public int SubjectId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public Subject()
		{
		}
	}
}
