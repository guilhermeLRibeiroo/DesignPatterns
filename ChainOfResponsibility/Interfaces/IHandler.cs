namespace ChainOfResponsibility.Interfaces
{
    interface IHandler
    {
        IHandler SetNext(IHandler handler);
        string Execute(int request);
    }
}
