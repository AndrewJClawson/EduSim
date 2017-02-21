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
		//private readonly Repository<Profile> _profileRepository;
		//private readonly Repository<ProfilePermission> _profilePermissionRepository;
		private EduSimContext _context;
		public ProfileService(EduSimContext context)
		{
			_context = context;
			//_profileRepository = new Repository<Profile>();
			//_profilePermissionRepository = new Repository<ProfilePermission>();
		}

		public void Add(Profile profile)
		{
			_context.Profiles.Add(profile);
			_context.SaveChanges();
		}


		public void Delete(Profile profile)
		{
			_context.Entry(profile).State = EntityState.Deleted;
			_context.Profiles.Attach(profile);
			_context.Profiles.Remove(profile);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			Profile profile = _context.Profiles.Find(id);
			Delete(profile);
		}

		public System.Collections.Generic.IEnumerable<Profile> GetProfiles()
		{
			return _context.Profiles;
		}

		public Profile GetForUser(string userId)
		{
			Profile profile = _context.Profiles
				.Where(p => p.UserId == userId)
				.FirstOrDefault();
			return profile;
		}

		public Profile GetById(int id)
		{
			Profile profile = _context.Profiles.Find(id);
			return profile;
		}

		public void Update(Profile profile)
		{
			_context.Entry(profile).State = EntityState.Modified;
			_context.Profiles.Attach(profile);
			_context.SaveChanges();
		}
	}
}
