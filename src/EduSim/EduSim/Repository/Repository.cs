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
using System.Web;
using EduSim.Contexts;

namespace EduSim.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected EduSimContext _edusimContext;
		private readonly DbSet<T> _dbSet;
		public Repository(DbContext dbContext)
		{
			_edusimContext = (EduSimContext)dbContext;
			_dbSet = _edusimContext.Set<T>();
		}

		public T GetById(object id)
		{
			return _dbSet.Find(id);
		}

		public IQueryable<T> GetAll(params string[] navigationProperties)
		{
			IQueryable<T> dbQuery = _edusimContext.Set<T>();
			foreach (string navigationProperty in navigationProperties)
			{
				dbQuery = dbQuery.Include(navigationProperty);
			}
			return dbQuery;
		}

		public virtual void Add(T item)
		{
			
			_dbSet.Add(item);
			_edusimContext.Entry(item).State = EntityState.Added;
		}

		public virtual void Delete(object id)
		{
			T deleteItem = _dbSet.Find(id);

			//TODO - Check for null object????
			Delete(deleteItem);

			//TODO - Update state ??
		}

		public virtual void Delete(T item)
		{
			// More here check if item state is detached. If it is, attach it.
			_dbSet.Remove(item);
			_edusimContext.Entry(item).State = EntityState.Deleted;
		}

		public virtual void Update(T item)
		{
			//TODO - null checks on item????
			_dbSet.Attach(item);
			_edusimContext.Entry(item).State = EntityState.Modified;
		}
	}
}
