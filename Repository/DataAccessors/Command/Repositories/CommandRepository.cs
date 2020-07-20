using Core.DataAccessors.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccessors.Command.Repositories
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        private readonly CqrsContext _context;
        public CommandRepository(CqrsContext context)
        {
            _context = context;
        }

        public T Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("entity");
            }
            _context.Add(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
