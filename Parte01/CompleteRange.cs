using System;
using System.Collections.Generic;
using System.Linq;

namespace Parte01
{
    public class CompleteRange
    {
        public static List<int> Build(List<int> plista)
        {
            var vlista = new List<int>();

            var vmax = plista.Max();
            for (int i = 1; i <= vmax; i++)
                vlista.Add(i);
            return vlista;
        }
    }
}
