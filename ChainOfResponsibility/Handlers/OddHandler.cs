namespace ChainOfResponsibility.Handlers
{
    class OddHandler
        : AbstractHandler
    {
        public override string Execute(int request)
        {
            if (request % 2 != 0)
            {
                return $"OddHandler: {request}";
            }

            return base.Execute(request);
        }
    }
}
