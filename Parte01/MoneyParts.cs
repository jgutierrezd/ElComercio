using System;
using System.Collections.Generic;
using System.Linq;

namespace Parte01
{
    public class MoneyParts
    {
        public static void Build(List<decimal> monedas, List<decimal> denominaciones, decimal highest, decimal suma, decimal valorObjetivo)
        {
            if (suma == valorObjetivo)
            {
                Display(monedas, denominaciones);
                return;
            }
            if (suma > valorObjetivo)
            {
                return;
            }
            foreach (decimal valor in denominaciones)
            {
                if (valor >= highest)
                {
                    List<decimal> copy = new List<decimal>(monedas);
                    copy.Add(valor);
                    Build(copy, denominaciones, valor, suma + valor, valorObjetivo);
                }
            }
        }

        static void Display(List<decimal> monedas, List<decimal> denominaciones)
        {
            var array = new List<string>();
            foreach (decimal monto in denominaciones)
            {
                int count = monedas.Count(value => value == monto);
                if (count > 0)
                {
                    string arrayLine = string.Empty;
                    arrayLine += string.Format("[{0}", monto);
                    for (int i = 1; i < count; i++)
                    {
                        arrayLine += string.Format(",{0}", monto);
                    }
                    arrayLine += "]";
                    array.Add(arrayLine);
                }

            }
            Console.WriteLine(string.Join(",", array));
        }
    }
}
