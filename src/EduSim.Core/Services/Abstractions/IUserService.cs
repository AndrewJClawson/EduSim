using System;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Services
{
	public interface IUserService
	{
		void Add(User user);
		bool Authenticate(string email, string password);
		void Delete(User user);
		void Delete(int id);
		List<User> GetAll();
		User GetByCredentials(string email, string password);
		User GetById(int id);
		void Update(User user);
	}
}
