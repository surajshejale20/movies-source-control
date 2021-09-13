using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        IList<T> GetAll();
        T GetById(int id);
        bool IsExists(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
