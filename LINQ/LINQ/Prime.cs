using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Prime
    {
        static void MainPrime(string[] args)
        {
            List<int> listeInt = new List<int>();
            for(int i = 1; i <= 100; i++)
            {
                listeInt.Add(i);
            }
            List<int> nbrPremiers = (from entier in listeInt
                                     where IsPrime(entier)
                                     select entier).ToList();
            foreach (int entier in nbrPremiers)
            {
                Console.Write(entier + " ");
            }
        }

        public static bool IsPrime(int n)
        {
            int i;
            for (i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            if (i == n)
            {
                return true;
            }
            return false;
        }
    }
}
