using System;
using System.Collections.Generic;
using System.Text;

namespace SociétéTableau
{
    class Employé : Personne
    {
        private decimal _Salaire;


        public decimal Salaire
        {
            get => _Salaire;
            set => _Salaire = Salaire;
        }

        public Employé(String nom, String prenom, int age,decimal salaire):base(nom,prenom,age)
        {
            _Salaire = salaire;
        }

        override public String ToString() => base.ToString() + " " + _Salaire +" EUR/mois";

        override public void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
