using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Core.Interfaces.Infrastructures
{
    public interface IBaseProvider<TEntity> where TEntity : class
    {
        Task<TEntity> Add();
        Task<IEnumerable<TEntity>> Get();
        Task<TEntity> Get(int id);
        Task<TEntity> Get(string id);
        
        Task<TEntity> Delete(int id);
        Task<TEntity> Delete(string id);
        Task<TEntity> Update(int id);
        Task<TEntity> Update(string id);
    }
}
