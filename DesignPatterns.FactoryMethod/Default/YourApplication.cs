using DesignPatterns.FactoryMethod.Default.Framework;

namespace DesignPatterns.FactoryMethod.Default
{
    public class YourApplication : Application
    {
        public override Document CreateDocument() => new YourDocument();
    }
}
