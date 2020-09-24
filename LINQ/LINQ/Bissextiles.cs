using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Bissextiles
    {
        static void MainBissextiles(string[] args)
        {
            List<int> Annees = new List<int> { 2001,2002,2003,2005};
            var query = from annee in Annees
                        where isBissextile(annee)
                        select annee;
            int nbrAnnee = query.Count();
            if(nbrAnnee != 0)
            {
                List<int> anneesBissextiles = query.ToList();
                foreach (int annee in anneesBissextiles)
                {
                    Console.Write(annee + " ");
                }
            }
            else
            {
                int annee = Annees.Max();
                while (!isBissextile(annee))
                {
                    annee++;
                }
                Console.WriteLine("Aucune année bissextile trouvée dans la liste. L'année bissextile la plus proche est " + annee);
            } 
        }

        static bool isBissextile(int annee)
        {
            if (annee % 4 != 0)
            {
                if (annee % 100 != 0)
                {
                    if (annee % 400 != 0) return false;
                    else return true;
                }
                else return false;
            }
            else return true;
        }
    }
}
