using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EduSim.DataModel.EF;
using EduSim.Models;
using EduSim.Contexts;

namespace EduSim.DataRepository
{
	public class DataRepository<TRepoItem> : IDataRepository<TRepoItem> where TRepoItem : class
	{
		protected EduSimContext _edusimContext;
		private readonly DbSet<TRepoItem> _dbSet;
		public DataRepository(DbContext dbContext)
		{
			_edusimContext = (EduSimContext)dbContext;
			_dbSet = _edusimContext.Set<TRepoItem>();
		}

		public TRepoItem GetById(object id)
		{
			return _dbSet.Find(id);
		}

		public IQueryable<TRepoItem> GetAll(params string[] navigationProperties)
		{
			IQueryable<TRepoItem> dbQuery = _edusimContext.Set<TRepoItem>();
			foreach (string navigationProperty in navigationProperties)
			{
				dbQuery = dbQuery.Include(navigationProperty);
			}
			return dbQuery;
		}

		public virtual void Add(TRepoItem item)
		{
			_dbSet.Add(item);
			_edusimContext.Entry(item).State = EntityState.Added;
		}

		public virtual void Delete(object id)
		{
			TRepoItem deleteItem = _dbSet.Find(id);
			//TODO - Check for null object????
			Delete(deleteItem);

			//TODO - Update state ??
		}

		public virtual void Delete(TRepoItem item)
		{
			// More here check if item state is detached. If it is, attach it.
			_dbSet.Remove(item);
			_edusimContext.Entry(item).State = EntityState.Deleted;
		}

		public virtual void Update(TRepoItem item)
		{
			//TODO - null checks on item????
			_dbSet.Attach(item);
			_edusimContext.Entry(item).State = EntityState.Modified;
		}
	}
}
