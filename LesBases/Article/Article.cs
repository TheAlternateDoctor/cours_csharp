using System;
using System.Collections.Generic;
using System.Text;

namespace Article
{
    struct Article
    {
        private String nom;
        private double prix;
        private int quantite;

        public Article(String nom, double prix, int quantiteInitiale)
        {
            this.nom = nom;
            this.prix = prix;
            quantite = quantiteInitiale;
        }

        public void Afficher()
        {
            Console.WriteLine("L'article " + nom + " coûte " + prix + " euros. On en a " + quantite + ".");
        }

        public void Ajouter(int quantite)
        {
            this.quantite += quantite;
        }

        public void Retirer(int quantite)
        {
            this.quantite -= quantite;
        }
    }
}
