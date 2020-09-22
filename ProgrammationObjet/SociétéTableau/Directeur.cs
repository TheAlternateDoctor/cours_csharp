using System;
using System.Collections.Generic;
using System.Text;

namespace SociétéTableau
{
    class Directeur: Chef
    {
        private String _Societe;
        public String Societe => _Societe;

        public Directeur(string nom, string prenom, int age, decimal salaire, string service, String Societe) : base(nom, prenom, age, salaire, service)
        {
            _Societe = Societe;
        }
        public override string ToString() => base.ToString() + " societe:" + _Societe;

        public override void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
