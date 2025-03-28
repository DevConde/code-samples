using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DapperGenericRepository.Infrastructure.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<int> CountAll();
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }

}
