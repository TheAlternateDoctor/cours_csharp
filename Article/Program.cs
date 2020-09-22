using System;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            Article dvdram = new Article("DVD-RAM", 2, 20);
            Article cassettes = new Article("Cassette type I", 1.5, 50);
            Article cdrom = new Article("CD-ROM haute capacité", .5, 100);

            dvdram.Afficher();
            cassettes.Afficher();
            cdrom.Afficher();
            cassettes.Ajouter(25);
            cassettes.Afficher();
            cdrom.Retirer(42);
            cdrom.Afficher();
        }
    }
}
