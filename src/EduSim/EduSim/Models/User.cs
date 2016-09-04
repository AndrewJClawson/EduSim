using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Data.Linq.Mapping;
//using MySql.Data.Entity;


namespace EduSim.Models
{
	[Table (Name="User")]
	public class User : DataModel
	{
		#region - Member variables
		[Column(Name = "id")]
		private int id { get; set;}
		public int ID
		{
			get
			{
				return id;
			}
			set 
			{
				id = value;
			}
		}

		[Column(Name="first_name")]
		private string first_name { get; set;}
		public string FirstName
		{
			get{
				return first_name;
			}
			set{
				first_name = value;
			}
		}

		[Column(Name = "last_name")]
		private string last_name { get; set;}
		public string LastName
		{
			get{
				return last_name;
			}
			set{
				last_name = value;
			}
		}

		[Column(Name = "email")]
		private string email { get; set;}
		public string Email
		{
			get{
				return email;
			}
			set{
				email = value;
			}
		}

		[Column(Name = "password")]
		private string password;
		public string Password
		{
			get{
				return password;
			}
			set{
				password = value;
			}
		}
		#endregion

		//Constructor
		public User()
		{
			
		}





		#region - Validation Methods
		public override List<string> GetValidationErrors()
		{
			List<string> _validationErrors = new List<string>();

			return _validationErrors;
		}


		#endregion

	}
}

