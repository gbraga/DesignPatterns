using System;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pmwFactory = new PmwFactory();

            var pmwScroll = pmwFactory.CreateScrollBar();
            Console.WriteLine(pmwScroll.ToString());

            var pmwWindow = pmwFactory.CreateWindow();
            Console.WriteLine(pmwWindow.ToString());

            var motifFactory = new MotifFactory();

            var motifScroll = motifFactory.CreateScrollBar();
            Console.WriteLine(motifScroll.ToString());

            var motifWindow = motifFactory.CreateWindow();
            Console.WriteLine(motifWindow.ToString());


            Console.ReadKey();
        }
    }
}
