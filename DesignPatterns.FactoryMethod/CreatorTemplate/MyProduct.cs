namespace DesignPatterns.FactoryMethod.CreatorTemplate
{
    public class MyProduct : Product
    {
        private Creator<MyProduct> _myCreator;

        public MyProduct()
        {
            _myCreator = new Creator<MyProduct>();
        }

        public override string ToString()
        {
            return $"Classe MyProduct::{_myCreator.CreatorMethod().ToString()}";
        }
    }
}
