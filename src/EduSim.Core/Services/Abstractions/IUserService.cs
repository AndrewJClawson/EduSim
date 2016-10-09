using System;
using System.Collections.Generic;
using EduSim.Core.Models;
namespace EduSim.Core.Services
{
	public interface IUserService
	{
		void Add(User user);
		void Delete(User user);
		void Delete(int id);
		List<User> GetAll();
		User GetById(int id);
		void Update(User user);
	}
}
