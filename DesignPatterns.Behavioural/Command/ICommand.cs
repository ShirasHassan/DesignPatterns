using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Command
{
    public interface ICommand
    {
        string Verb { get; }
        IReadOnlyDictionary<string,string> Args { get; }
        CommandResult Execute();
    }
}