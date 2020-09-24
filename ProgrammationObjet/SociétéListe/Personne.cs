using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;

namespace Société
{
    class Personne
    {
        private String _Nom;
        public String Nom => _Nom;
        private String _Prenom;
        public String Prenom => _Prenom;
        private int _Age;
        public int Age
        {
            get => _Age;
            set => _Age = value;
        }

        public static Personne operator ++(Personne a)
        {
            int age = a.Age+1;
            return new Personne(a.Nom,a.Prenom,age);
        }

        public Personne(string nom, string prenom, int age)
        {
            _Nom = nom;
            _Prenom = prenom;
            _Age = age;
        }public Personne(string nom, string prenom)
        {
            _Nom = nom;
            _Prenom = prenom;
        }

        override public String ToString() => $"{_Nom} {_Prenom} {_Age} ans";


        virtual public void Afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
