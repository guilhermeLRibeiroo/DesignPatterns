namespace Mediator.Mediators
{
    public interface IMediator
    {
        public void Notify(object sender, string _event);
    }
}
