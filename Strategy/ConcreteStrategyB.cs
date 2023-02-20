namespace Strategy
{
    public class ConcreteStrategyB
        : IStrategy
    {
        public object SortCollection(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
