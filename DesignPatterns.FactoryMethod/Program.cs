﻿using System;

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

            Console.ReadKey();
        }
    }
}
