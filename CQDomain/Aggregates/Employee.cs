using System;
using System.Collections.Generic;
using System.Text;

namespace CQDomain.Aggregates
{
    public class Employee : AggregateRoot
    {
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;


        public Employee() { }
        public Employee(Guid aggregateId, int employeeID, string firstName, string lastName, DateTime dateOfBirth)
        {
            Id = aggregateId;
            _employeeID = employeeID;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;

            // apply event ?
        }
    }
}
