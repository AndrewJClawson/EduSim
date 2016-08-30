using System;
using System.Collections.Generic;
namespace EduSim.Models
{
	public class DataModel : IValidatable
	{
		private int id { get; set; }
		public int ID
		{
			get
			{
				return id;
			}
			set
			{
				this.id = value;
			}
		}

		private string tablename {get;set;}
		public string Tablname
		{
			get{
				return this.tablename;
			}
			set{
				this.tablename = value;
			}
		}


		#region - Constructor
		public DataModel()
		{
		}
		#endregion



		#region - Validation Methods
		public virtual List<string> GetValidationErrors()
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

		#endregion
	}
}

