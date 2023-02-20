namespace Strategy
{
    public class ConcreteStrategyA
        : IStrategy
    {
        public object SortCollection(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
