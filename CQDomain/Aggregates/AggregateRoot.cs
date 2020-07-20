using System;
using System.Collections.Generic;
using System.Text;

namespace CQDomain.Aggregates
{
    public abstract class AggregateRoot
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }



    }
}
