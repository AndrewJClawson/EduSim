using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduSim.Web.Models
{
	public class WebAppState : IWebState
	{
		public int? AccountID
		{
			get {return HttpContext.Current.User.Identity.GetAccountId();
		}

		public int? EduSIMUserID
		{
				get {return HttpContext.Current.User.Identity.GetEduSIMUserID();
		}
	}


}
