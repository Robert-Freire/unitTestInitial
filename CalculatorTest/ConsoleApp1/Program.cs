using Calculator;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new TokidoKiFacturator();
            if (calculator.calcular(5, 3) == 17)
            {
                Console.WriteLine("ok!");
            } else
            {
                Console.WriteLine("fail!");
            }
            Console.ReadLine();
        }
    }
}
