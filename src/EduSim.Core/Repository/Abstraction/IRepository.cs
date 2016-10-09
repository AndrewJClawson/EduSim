using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduSim.Core.Repository
{
	public interface IRepository<T> where T : class
	{
		T GetById(object id);
		IQueryable<T> GetAll(params string[] navProperties);
		void Add(T item);
		void Delete(T item);
		void Delete(object id);
		void Update(T item);
	}
}
