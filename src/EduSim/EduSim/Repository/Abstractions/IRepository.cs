using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduSim.Repository
{
	public interface IRepository<T> where T : class
	{
		T GetById(object id);
		IQueryable<T> GetAll(params string[] navigationProperties);
		//IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params string[] navigationProperties);
		void Add(T item);
		void Delete(T item);
		void Delete(object id);
		void Update(T item);
	}
}
