using System;
using System.Linq;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.Contexts;
using EduSim.Core.Repository;
using System.Data.Entity;

using MySql.Data.Entity;

namespace EduSim.Core.Services
{
	public class UserService
	{
		private readonly Repository<User> _userRepository;

		public UserService()
		{
		}

		public void Add(User user)
		{
			_userRepository.Add(user);
		}

		public void Delete(User user)
		{
			_userRepository.Delete(user);
		}

		public void Delete(int id)
		{
			_userRepository.Delete(id);
		}

		public List<User> GetAll()
		{
			List<User> users = _userRepository.GetAll().ToList();
			return users;
		}

		public User GetById(int id)
		{
			User user = _userRepository.GetById(id);
			return user;
		}

		public void Update(User user)
		{
			_userRepository.Update(user);
		}
	}
}
