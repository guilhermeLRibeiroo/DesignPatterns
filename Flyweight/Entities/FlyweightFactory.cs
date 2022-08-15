namespace Entities
{
    class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach(var element in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(element), FlyweightStringHashKey(element)));
            }
        }


        public string FlyweightStringHashKey(Car key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = FlyweightStringHashKey(sharedState);

            if(flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("The FlyweightFactory can't find a flyweight, creating new one.");
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("The FlyweightFactory is reusing a existing flyweight.");
            }

            return flyweights.FirstOrDefault(t => t.Item2 == key).Item1;
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
