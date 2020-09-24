using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LINQ
{
    class DivParCinq
    {
        static void Main(string[] args)
        {
            List<int> nombres = new List<int> { 5,11,15,22,42,38,75};
            List<int> divisibles = nombres.Where(valeur => valeur % 5 == 0).ToList();
            foreach (int nombre in divisibles)
            {
                Console.Write(nombre + " ");
            }
        }
    }
}
