using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema01
            Console.WriteLine(ChangeString.Build("123 abcd*3"));
            Console.WriteLine(ChangeString.Build("**Casa 52"));
            Console.WriteLine();

            //Problema02
            var lista = new List<int> { 5, 6, 7, 18, 59, 10 };
            CompleteRange.Build(lista);
            foreach (var item in CompleteRange.Build(lista))
            Console.Write(item+",");
            Console.WriteLine();

            //Problema03
            var monedas = new List<decimal>();
            var denominaciones = new List<decimal> { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
            MoneyParts.Build(monedas, denominaciones, 0, 0, 0.5m);
            Console.ReadKey();
        }
    }
}
