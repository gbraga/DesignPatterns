using DesignPatterns.FactoryMethod.Default.Framework;

namespace DesignPatterns.FactoryMethod.Default
{
    public class YourDocument : Document
    {
        public override Document Open()
        {
            return this;
        }

        public override string ToString()
        {
            return "Classe Concreta: YourDocument";
        }
    }
}
