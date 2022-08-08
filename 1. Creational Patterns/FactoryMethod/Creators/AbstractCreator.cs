using FactoryMethod.Interfaces;

namespace FactoryMethod.Creators
{
    abstract class AbstractCreator
    {
        public abstract IProduct FactoryMethod();

        public string Execute()
        {
            var product = FactoryMethod();

            var result = string.Format("Creator: Product Operation: {0}", product.Operation());

            return result;
        }
    }
}
