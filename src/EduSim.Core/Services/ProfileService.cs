using System;
using System.Linq;
using System.Collections.Generic;
using EduSim.Core.ModelInterfaces;
using EduSim.Core.Contexts;
using EduSim.Core.Repository;
using System.Data.Entity;

using MySql.Data.Entity;

namespace EduSim.Core.Services
{
	public class ProfileService : IProfileService
	{
		private readonly Repository<IProfile> _profileRepository;

		public ProfileService()
		{
			_profileRepository = new Repository<IProfile>();
		}

		public void Add(IProfile profile)
		{
			_profileRepository.Add(profile);
		}


		public void Delete(IProfile profile)
		{
			_profileRepository.Delete(profile);
		}

		public void Delete(int id)
		{
			_profileRepository.Delete(id);
		}

		public List<IProfile> GetAll()
		{
			List<IProfile> users = _profileRepository.GetAll().ToList();
			return users;
		}

		public IProfile GetProfileForUser(string userId)
		{
			IProfile profile = _profileRepository
				.GetAll()
				.Where(p => p.UserId == userId)
				.FirstOrDefault();
			return profile;
		}

		public IProfile GetById(int id)
		{
			IProfile profile = _profileRepository.GetById(id);
			return profile;
		}

		public void Update(IProfile profile)
		{
			_profileRepository.Update(profile);
		}
	}
}
