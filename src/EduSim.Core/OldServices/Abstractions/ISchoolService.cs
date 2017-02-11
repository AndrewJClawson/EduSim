using System;
using System.Collections.Generic;

using EduSim.Core.Models;

namespace EduSim.Core.Services
{
	public interface ISchoolService
	{
		void Add(School school);
		void Delete(School school);
		void Delete(int id);
		List<School> GetAll();
		School GetById(int id);
		void Update(School school);
	}
}
