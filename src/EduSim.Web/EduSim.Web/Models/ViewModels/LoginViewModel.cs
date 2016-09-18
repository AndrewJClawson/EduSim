using System;
using EduSim.Web;
using EduSim;

namespace EduSim.Web.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{
		public string Email {get;set;}
		public string Password {get;set;}

		public LoginViewModel()
		{
			
		}
	}
}
