using System;
using System.Linq;
using System.Collections.Generic;
using EduSim.Core.Repository;

using EduSim.Core.Models;


namespace EduSim.Core.Services
{
	public class SchoolService : ISchoolService
	{
		private readonly Repository<School> _schoolRepository;

		public SchoolService()
		{
			_schoolRepository = new Repository<School>();
		}

		public void Add(School school)
		{
			_schoolRepository.Add(school);
		}

		public void Delete(School school)
		{
			_schoolRepository.Delete(school);
		}

		public void Delete(int id)
		{
			_schoolRepository.Delete(id);
		}

		public List<School> GetAll()
		{
			List<School> schools = _schoolRepository.GetAll().ToList();
			return schools;
		}

		public School GetById(int id)
		{
			School school = _schoolRepository.GetById(id);
			return school;
		}

		public void Update(School school)
		{
			_schoolRepository.Update(school);
		}

	}
}
