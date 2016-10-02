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
			_accountRepository = new Repository<Account>(Context);
		}


	}
}
