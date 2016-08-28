using System;
using System.Collections.Generic;
namespace EduSim.Models
{
	public class DataModel : IValidatable
	{
		public DataModel()
		{
		}

		public List<string> GetValidationErrors()
		{
			List<string> _validationErrors = new List<string>();

			return _validationErrors;
		}

		public bool IsValid()
		{
			if (GetValidationErrors().Count == 0)
			{
				return true;
			}
			return false;
		}
	}
}

