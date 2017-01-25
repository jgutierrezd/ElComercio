using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01
{
    public class ChangeString
    {
        public static string Build(string pcadena)
        {
            var vArray = new char[pcadena.Length];
            var vIndex = 0;
            foreach (char item in pcadena)
            {
                if (char.IsLetter(item))
                    vArray[vIndex++] = (char)(item + 1);
                else
                    vArray[vIndex++] = item;
            }
            return new string(vArray);
        }
    }
}
