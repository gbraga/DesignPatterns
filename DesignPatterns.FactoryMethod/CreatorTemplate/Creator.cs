namespace DesignPatterns.FactoryMethod.CreatorTemplate
{
    public class Creator<T> where T : class, new()
    {
        public virtual T CreatorMethod() => new T();
    }
}
