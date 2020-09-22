using System;

namespace LesBases
{
    class Program
    {
        static void Main(string[] args)
        {
            Broche rpo = new Broche(0099560437,"Ready Player One",374,8);
            Poche histoiretemps = new Poche(2082111822, "Une brève histoire du temps", 228, 6, "Sciences");
            Disque monsters = new Disque("Counter Records", "Monsters (The Midnight)", 9);
            Video bttf = new Video(116, "Retour vers le Futur", 15);
            rpo.Acheter();
            histoiretemps.Acheter();
            monsters.Acheter();
            bttf.Acheter();
            monsters.Ecouter();
            bttf.Afficher();
        }
    }

    class Article
    {
        protected String designation;
        protected int prix;

        protected Article(String designation, int prix)
        {
            this.designation = designation;
            this.prix = prix;
        }

        public void Acheter()
        {
            Console.WriteLine("Achat d'un " + this.GetType().Name + " \"" + designation + "\" à " + prix + "euros acheté.");
        }
    }

    class Livre : Article
    {
        protected int isbn;
        protected int nbPages;

        protected Livre(int isbn, String designation, int nbPages, int prix) : base(designation, prix)
        {
            this.isbn = isbn;
            this.nbPages = nbPages;
        }
    }
    class Disque : Article
    {
        protected String label;

        public Disque(String label, String designation, int prix) : base(designation, prix)
        {
            this.label = label;
        }

        public void Ecouter()
        {
            Console.WriteLine("Now playing - " + designation + " (Published by " + label + ")");
        }
    }
    class Video : Article
    {
        protected float duree; //En mn

        public Video(float duree, String designation, int prix) : base(designation, prix)
        {
            this.duree = duree;
        }

        public void Afficher()
        {
            Console.WriteLine("Vous êtes en train de regarder " + designation + " d'une durée totale de " + duree + "mn.");
        }
    }
    class Broche : Livre
    {
        public Broche(int isbn, String designation, int nbPages, int prix) : base(isbn, designation, nbPages, prix) { }
    }
    class Poche : Livre
    {
        private String categorie;
        public Poche(int isbn, String designation, int nbPages, int prix, String categorie) : base(isbn, designation, nbPages, prix)
        {
            this.categorie = categorie;
        }
    }
}
