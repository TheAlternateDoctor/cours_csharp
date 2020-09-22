using System;
using System.Collections.Generic;
using System.Text;

namespace SociétéTableau
{
    class Chef : Employé
    {
        private String _Service;

        public String Service
        {
            get => _Service;
            set => _Service = value;
        }

        public Chef(String nom, String prenom, int age, decimal salaire,string service): base(nom, prenom, age, salaire)
        {
            _Service = service;
        }
        public override string ToString() => base.ToString()+" service:" + _Service;
        override public void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
