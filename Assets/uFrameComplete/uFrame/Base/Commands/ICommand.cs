using System;
using System.Collections;

public delegate void CommandEvent();

/// <summary>
/// The base command interface for implementing a command in a ViewModel
/// </summary>
public interface ICommand
{
    string Identifier { get; set; }

    event CommandEvent OnCommandExecuted;

    event CommandEvent OnCommandExecuting;
    object Sender { get; set; }
    object Parameter { get; set; }

    IEnumerator Execute();
}

/// <summary>
/// A base command interface for implementing a command with a parameter in a ViewModel
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICommandWith<T> : ICommand
{
    //IEnumerator Execute(T parameter);
}
[Obsolete("Use ICommandWith<TArgument>")]
public interface ICommand<T> : ICommand
{
    
}

//public class YieldCommand : ICommand
//{
//    public Func<IEnumerator> EnumeratorFunc { get; set; }

//    public IEnumerator Enumerator { get; set; }

//    public IEnumerator Execute()
//    {
//        Enumerator = ExecuteEnumerator();

//    }

//    public IEnumerator ExecuteEnumerator()
//    {
//        return EnumeratorFunc();
//    }
//}