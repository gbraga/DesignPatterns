namespace DesignPatterns.FactoryMethod
{
    public class MyDocument : Document
    {
        public override Document Open()
        {
            return this;
        }

        public override string ToString()
        {
            return $"Classe Concreta: {this}";
        }
    }
}
