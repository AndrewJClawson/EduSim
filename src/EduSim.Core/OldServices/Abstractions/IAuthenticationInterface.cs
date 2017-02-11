using System;
using System.Collections.Generic;
using EduSim.Core.Models;

namespace EduSim.Core.Services
{
	public interface IAuthenticationInterface
	{
		bool Authenticated(string email, string password);
	}
}
