using Core.DataAccessors.Command.Interfaces;
using Core.Dtos;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQDomain.Commands
{
    public class CreateEmployee : IRequest
    {
        public readonly int EmployeeID;
        public readonly string FirstName;
        public readonly string LastName;
        public readonly DateTime DateOfBirth;

        public CreateEmployee(int employeeID, string firstName, string lastName, DateTime dateOfBirth)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }


        internal sealed class CreateEmployeeHandler : IRequestHandler<CreateEmployee>
        {
            private readonly ICommandRepository<Employee> repository;

            public CreateEmployeeHandler(ICommandRepository<Employee> repository)
            {
                this.repository = repository;
            }

            public Task<Unit> Handle(CreateEmployee request, CancellationToken cancellationToken)
            {
                repository.Insert(new Employee
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    DateOfBirth = request.DateOfBirth
                });

                return Unit.Task;
            }
        }
    }
}
