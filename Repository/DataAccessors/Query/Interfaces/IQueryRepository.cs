using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataAccessors.Query.Interfaces
{
    public interface IQueryRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        IQueryable<T> ToQueryable();
    }
}
