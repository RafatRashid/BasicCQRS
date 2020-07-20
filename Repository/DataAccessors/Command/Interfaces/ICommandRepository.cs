using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccessors.Command.Interfaces
{
    public interface ICommandRepository<T>
    {
        T Insert(T entity);
    }
}
