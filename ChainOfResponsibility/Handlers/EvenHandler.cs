namespace ChainOfResponsibility.Handlers
{
    class EvenHandler
        : AbstractHandler
    {
        public override string Execute(int request)
        {
            if(request % 2 == 0)
            {
                return $"EvenHandler: {request}";
            }

            return base.Execute(request);
        }
    }
}
