using Newtonsoft.Json;

namespace Entities
{
    class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string shared = JsonConvert.SerializeObject(_sharedState);
            string unique = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: shared {shared} and unique {unique} state.");
        }
    }
}
