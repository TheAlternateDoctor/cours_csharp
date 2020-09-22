using System;

namespace Personnes
{
    class TestPersonne
    {
        static void ThrowawayPersonne() //Permet de créer une personne qui ne sera pas utilisée, et devrait normalement être détruite à la fin de la fonction
        {
            Personne personne = new Personne("", "", 0);
        }

        static void Main(string[] args)
        {
            Personne personne1 = new Personne("Auxpommes", "Tarte", 26);
            Personne personne2 = new Personne("Auxfraises", "Bavarois", 53);
            Personne personne3 = new Personne("Auchocolat", "Mousse", 14);
            ThrowawayPersonne();
            ThrowawayPersonne();
            personne3.Combien();
        }
    }
}
