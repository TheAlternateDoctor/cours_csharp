using System;
using System.Collections.Generic;
using System.Text;
using ListeChainée;
using Société;

namespace SociétéEnumération
{
    class GérerSociétéEnumération
    {
        public static void Main(string[] args)
        {
            Liste société = new Liste();
            object tira_misu = new Employé("Misu", "Tira", 22, 1_500);
            object tarte_chocolat = new Employé("Chocolat", "Tarte", 26, 1_700);
            object snicker_doodle = new Employé("Doodle", "Snicker", 18, 1_300);
            object cane_le_bordelais = new Employé("Le Bordelais", "Cane", 35, 1_900);
            object crême_brulée = new Employé("Brulée", "Crême", 50, 2_000);
            object finn_ancier = new Chef("Ancier", "Finn", 22, 2_600, "Comptable");
            object macaron_chocolat = new Chef("Chocolat", "Macaron", 22, 2_900, "RH");
            object tarte_auxpommes = new Directeur("Auxpommes", "Tarte", 45, 3_400, "PDG", "Okie Co.");
            société.InsérerFin(ref tira_misu);
            société.InsérerFin(ref tarte_chocolat);
            société.InsérerFin(ref snicker_doodle);
            société.InsérerFin(ref cane_le_bordelais);
            société.InsérerFin(ref crême_brulée);
            société.InsérerFin(ref finn_ancier);
            société.InsérerFin(ref macaron_chocolat);
            société.InsérerFin(ref tarte_auxpommes);
            Console.WriteLine("I'm using for loop!");
            for (int i = 0; i < société.NbEléments; i++)
            {
                Console.WriteLine(((Elément)société[i]).Objet);
            }
            Console.WriteLine("I'm using foreach loop!");
            foreach (Elément element in société)
            {
                Console.WriteLine(element.Objet);
            }
        }
    }
}
