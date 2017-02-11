using System;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Services
{
	public interface IProfileService
	{
		void Add(Profile profile);

		void Delete(Profile profile);
		void Delete(int id);
		List<Profile> GetAll();
		Profile GetForUser(string userId);
		Profile GetById(int id);
		void Update(Profile profile);
	}
}
