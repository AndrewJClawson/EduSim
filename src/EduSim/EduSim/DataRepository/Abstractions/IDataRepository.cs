using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduSim.DataRepository
{
	public interface IDataRepository<TRepoItem> where TRepoItem : class
	{
		TRepoItem GetById(object id);
		IQueryable<TRepoItem> GetAll(params string[] navigationProperties);
		IQueryable<TRepoItem> FindBy(Expression<Func<TRepoItem, bool>> predicate, params string[] navigationProperties);
		void Add(TRepoItem item);
		void Delete(TRepoItem item);
		void Delete(object id);
		void Update(TRepoItem item);
	}
}
