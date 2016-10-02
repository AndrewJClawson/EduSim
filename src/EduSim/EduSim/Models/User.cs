using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.Entity;
using EduSim.ModelInterfaces;
//using MySql.Data.Entity;


namespace EduSim.Models
{
	[Table("Users")]
	public class User : DataModel
	{
		#region - Member variables
		[Column("pk_user_id")]
		private int user_id { get; set;}

		public int UserID
		{
			get
			{
				return user_id;
			}
			set 
			{
				user_id = value;
			}
		}

		[Column("fk_account_id")]
		private int? account_id { get; set;  }

		public int? AccountID
		{
			get
			{
				return account_id;
			}
			set
			{
				account_id = value;
			}
		}

		[Column("first_name")]
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

		[Column("last_name")]
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

		[Column("email")]
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

		[Column("password")]
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

		[Column("is_admin"), MaxLength(1)]
		private string is_admin;
		public string IsAdmin
		{
			get { return is_admin;}
			set{
				is_admin = value;
			}
		}

		[Column("is_instructor"), MaxLength(1)]
		private string is_instructor;
		public string IsInstructor
		{
			get { return is_instructor; }
			set
			{
				is_instructor = value;
			}
		}

		[Column("is_volunteer"), MaxLength(1)]
		private string is_volunteer;
		public string IsVolunteer
		{
			get { return is_volunteer; }
			set
			{
				is_volunteer = value;
			}
		}


		#endregion


		//Constructor
		public User()
		{
			
		}

		public virtual Account Account { get; set; }
	}
}

