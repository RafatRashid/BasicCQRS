using Core.DataAccessors.Query.Interfaces;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQDomain.Queries
{
    public class GetAllEmployee: IRequest<List<Employee>>
    {
        public GetAllEmployee()
        {

        }

        internal sealed class GetAllEmployeeHandler : IRequestHandler<GetAllEmployee, List<Employee>>
        {
            private readonly IQueryRepository<Employee> repository;

            public GetAllEmployeeHandler(IQueryRepository<Employee> repository)
            {
                this.repository = repository;
            }

            public Task<List<Employee>> Handle(GetAllEmployee request, CancellationToken cancellationToken)
            {
                return Task.FromResult(repository.GetAll());
            }
        }
    }
}
