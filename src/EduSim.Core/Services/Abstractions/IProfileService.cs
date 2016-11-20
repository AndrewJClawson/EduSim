using System;
using System.Collections.Generic;
using EduSim.Core.Models;
using EduSim.Core.ModelInterfaces;

namespace EduSim.Core.Services
{
	public interface IProfileService
	{
		void Add(IProfile profile);

		void Delete(IProfile profile);
		void Delete(int id);
		List<IProfile> GetAll();
		IProfile GetForUser(string userId);
		IProfile GetById(int id);
		void Update(IProfile profile);
	}
}
