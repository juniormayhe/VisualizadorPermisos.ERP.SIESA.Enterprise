using System.Collections.Generic;
using Model;

namespace Data.Oracle.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> List();
    }
}