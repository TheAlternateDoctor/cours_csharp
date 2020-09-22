using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace Personnes
{
    class Personne
    {
        private String nom;
        private String prenom;
        private short age;
        public static int count = 0;


        public Personne(string nom, string prenom, short age) 
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            count++;
        }

        ~Personne() //Sans, Combien() retourne le nombre d'instances créées depuis le début du programme
        {
            count--;
        }
        public void Afficher()
        {
            Console.WriteLine($"Objet Personne {nom} {prenom} : {age} ans.");
        }

        public void Combien()
        {
            Console.WriteLine($"Depuis le lancement du programme, {count} instances de cette classe ont soit été créées, soit sont en cours d'utilisation (se référer au code pour connaitre le cas d'utilisation).");
        }

    }
}
