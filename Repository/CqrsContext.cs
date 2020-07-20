using Core.Entities;
using Core.FluentMaps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;

namespace Core
{
    public class CqrsContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }


        public CqrsContext(DbContextOptions<CqrsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
        }
    }
}
