using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Validation;
using MvcApplication1.Models;

namespace MvcApplication1.Infrastructure {
    public class GenericRepository : IGenericRepository {

        private DataContext _dataContext = new DataContext();

        /// <summary>
        /// Generic query method
        /// </summary>
        public IQueryable<T> Query<T>(params Expression<Func<T, object>>[] includeProperties) where T : class {
            var query = _dataContext.Set<T>().AsQueryable();
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }


        /// <summary>
        /// Generic query method with support for outer joins
        /// </summary>
        public IQueryable<T> Query<T>(Expression<Func<T, object>>[] includePropertiesAsDefaultIfEmpty, params Expression<Func<T, object>>[] includeProperties) where T : class {
            var query = _dataContext.Set<T>().AsQueryable();
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }

            foreach (var includeProperty in includePropertiesAsDefaultIfEmpty) {
                query = query.Include(includeProperty).DefaultIfEmpty();
            }
            return query;
        }


        /// <summary>
        /// Find row by id
        /// </summary>
        public T Find<T>(params object[] keyValues) where T : class {
            return _dataContext.Set<T>().Find(keyValues);
        }


        /// <summary>
        /// Add new entity
        /// </summary>
        public void Add<T>(T entityToCreate) where T : class {
            _dataContext.Set<T>().Add(entityToCreate);
        }


        public void Delete<T>(params object[] keyValues) where T : class {
            var entity = this.Find<T>(keyValues);
            _dataContext.Set<T>().Remove(entity);
        }


        /// <summary>
        /// Save changes and throw validation exceptions
        /// </summary>
        public void SaveChanges() {
            try {
                _dataContext.SaveChanges();
            } catch (DbEntityValidationException dbVal) {
                var firstError = dbVal.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                throw new ValidationException(firstError);
            }
        }


        /// <summary>
        /// Execute stored procedures and dynamic sql
        /// </summary>
        public IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters) {
            return this._dataContext.Database.SqlQuery<T>(sql, parameters);
        }





        public void Dispose() {
            _dataContext.Dispose();
        }


    }
}