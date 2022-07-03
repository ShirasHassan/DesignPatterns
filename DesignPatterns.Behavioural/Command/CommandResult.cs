using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Command
{
    public abstract class CommandResult
    {
        public readonly ICommand Command;

        public readonly IEnumerable<Contact> Results;

        protected CommandResult(ICommand command,IEnumerable<Contact> results)
        {
            Results = results;
            Command = command;
        }


        public abstract bool CanUndo();

        public abstract ICommand GetUndoCommand();
    }
}