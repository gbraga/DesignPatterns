using DesignPatterns.FactoryMethod.CreatorTemplate;
using DesignPatterns.FactoryMethod.Default;
using DesignPatterns.FactoryMethod.Default.Framework;
using System;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de Factory Method");

            var app = new MyApplication();
            // var doc = app.CreateDocument();
            var doc = app.NewDocument();
            Console.WriteLine(doc.ToString());


            var app2 = new MyProduct(); 

            Console.ReadKey();
        }
    }
}
