using System;
using System.Collections.Generic;

namespace EduSim.Models
{
	public interface IValidatable
	{
		List<string> GetValidationErrors();
		bool IsValid();
	}
}

