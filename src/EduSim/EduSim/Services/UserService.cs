using System;
using System.Linq;
using System.Collections.Generic;
using EduSim.Models;
using EduSim.Contexts;
using EduSim.Repository;
using System.Data.Entity;
using System.Data.Linq;
using MySql.Data.Entity;

namespace EduSim.Services
{
	public class UserService
	{
		private readonly Repository<User> _userRepository;
		private readonly Repository<Account> _accountRepository;

		public UserService()
		{
			_userRepository = new Repository<User>();
			_accountRepository = new Repository<Account>();
		}

		public UserService(DbContext context)
		{
			_userRepository = new Repository<User>(context);
			_accountRepository = new Repository<Account>(context);
		}

		public void Create(int accountId, string firstname, string lastname, string email, string password)
		{
			User userToAdd = new User();
			userToAdd.AccountId = accountId;
			userToAdd.FirstName = firstname;
			userToAdd.LastName = lastname;
			userToAdd.Email = email;
			userToAdd.Password = password;

			_userRepository.Add(userToAdd);
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
			User returnUser = _userRepository.GetById(id);
			return returnUser;
		}

		public void Update(User user)
		{
			_userRepository.Update(user);
		}
	}
}
