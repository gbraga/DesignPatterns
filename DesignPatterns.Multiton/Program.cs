using System;

namespace DesignPatterns.Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiton m0 = Multiton.GetInstance(MultitonType.ServiceFoo);
            Multiton m1 = Multiton.GetInstance(MultitonType.ServiceBar);
            Console.WriteLine(m0.ToString());
            Console.WriteLine(m1.ToString());

            Multiton m2 = Multiton.GetInstance(MultitonType.ServiceFoo);
            Multiton m3 = Multiton.GetInstance(MultitonType.ServiceBar);
            Console.WriteLine(m2.ToString());
            Console.WriteLine(m3.ToString());

            Console.ReadKey();
        }
    }
}
