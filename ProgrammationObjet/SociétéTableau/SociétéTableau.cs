using System;
using System.Collections.Generic;
using System.Text;

namespace SociétéTableau
{
    class SociétéTableau
    {
        static void Main(string[] args)
        {
            Personne[] societe = new Personne[8];
            societe[0] = new Employé("Misu", "Tira", 22,1_500);
            societe[1] = new Employé("Chocolat", "Tarte", 26,1_700);
            societe[2] = new Employé("Doodle", "Snicker", 18,1_300);
            societe[3] = new Employé("Le Bordelais", "Cane", 35,1_900);
            societe[4] = new Employé("Brulée", "Crême", 50,2_000);
            societe[5] = new Chef("Ancier", "Finn", 22,2_600,"Comptable");
            societe[6] = new Chef("Chocolat", "Macaron", 22,2_900,"RH");
            societe[7] = new Directeur("Auxpommes", "Tarte", 45,3_400,"PDG","Okie Co.");
            for (int i = 0; i < societe.Length; i++)
            {
                societe[i].Afficher();
            }
            Console.WriteLine();
            societe[0]++; //On perd des données; j'irais voir ça après
            ((Employé)societe[4]).Salaire = 2_200;//Ne marche pas. Je sais pas pourquoi, mais ça marche pas
            ((Chef)societe[6]).Service = "Ressources Humaines";
            foreach (Personne personne in societe)
            {
                Console.WriteLine(personne);
            }
        }
    }
}
