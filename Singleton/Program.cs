using System;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementacaoBasica();
        }

        static void ImplementacaoBasica()
        {
            var instance = ClasseSingleton.Instance();
            Console.WriteLine($"Primeira chamada: {instance.Id}");

            var instance2 = ClasseSingleton.Instance();
            Console.WriteLine($"Segunda chamada: {instance2.Id}");
        }
    }
}
