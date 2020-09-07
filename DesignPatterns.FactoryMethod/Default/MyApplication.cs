using DesignPatterns.FactoryMethod.Default.Framework;

namespace DesignPatterns.FactoryMethod.Default
{
    public class MyApplication : Application
    {
        public override Document CreateDocument() => new MyDocument();
    }
}
