using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleTypé
{
    struct Article
    {
        private String nom;
        private double prix;
        private int quantite;
        private Type type;
        public enum Type{
            SUPPORT,
            LECTEUR,
            ENCEINTES
        }

        public Article(String nom, double prix, int quantiteInitiale, Type type)
        {
            this.nom = nom;
            this.prix = prix;
            quantite = quantiteInitiale;
            this.type = type;
        }

        public void Afficher()
        {
            Console.WriteLine("L'article " + nom + " de type " + type + " coûte " + prix + " euros. On en a " + quantite + ".");
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
