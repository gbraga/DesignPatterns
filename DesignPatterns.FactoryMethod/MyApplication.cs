using DesignPatterns.FactoryMethod.Framework;

namespace DesignPatterns.FactoryMethod
{
    public class MyApplication : Application
    {
        public override Document CreateDocument() => new MyDocument();
    }
}
