using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SqlSugar.IRepository;
using SqlSugar.IService;

namespace SqlSugar.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// 子类中继承
        /// </summary>
        protected IBaseRepository<TEntity> _baseRepository;

        public Task<bool> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> QueryAsync()
        {
            return await _baseRepository.QueryAsync();
        }

        public Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QueryAsync(int page, int size, RefAsync<int> total)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func, int page, int size, RefAsync<int> total)
        {
            throw new NotImplementedException();
        }
    }
}
