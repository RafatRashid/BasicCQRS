using System;
using System.Collections.Generic;
using System.Text;

namespace CQDomain.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
