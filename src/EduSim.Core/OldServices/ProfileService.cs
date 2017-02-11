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
	public class ProfileService : IProfileService
	{
		private readonly Repository<Profile> _profileRepository;
		private readonly Repository<ProfilePermission> _profilePermissionRepository;

		public ProfileService()
		{
			_profileRepository = new Repository<Profile>();
			_profilePermissionRepository = new Repository<ProfilePermission>();
		}

		public void Add(Profile profile)
		{
			_profileRepository.Add(profile);
		}


		public void Delete(Profile profile)
		{
			_profileRepository.Delete(profile);
		}

		public void Delete(int id)
		{
			_profileRepository.Delete(id);
		}

		public List<Profile> GetAll()
		{
			List<Profile> profiles = _profileRepository.GetAll().ToList();
			return profiles;
		}

		public Profile GetForUser(string userId)
		{
			Profile profile = _profileRepository
				.GetAll()
				.Where(p => p.UserId == userId)
				.FirstOrDefault();
			return profile;
		}

		public Profile GetById(int id)
		{
			Profile profile = _profileRepository.GetById(id);
			return profile;
		}

		public void Update(Profile profile)
		{
			_profileRepository.Update(profile);
		}
	}
}
