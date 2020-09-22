using System;

namespace ArticleTypé
{
    class Program
    {
        static void Main(string[] args)
        {
            Article cassette = new Article("Cassette type I", 1.5, 100, Article.Type.SUPPORT);
            Article tapedeck = new Article("Tape Deck CT-W208R", 50, 5, Article.Type.LECTEUR);
            Article enceinte = new Article("MCD139B", 15, 20, Article.Type.ENCEINTES);

            cassette.Afficher();
            tapedeck.Afficher();
            enceinte.Afficher();

            Console.Write("Nom de l'article:");
            String artName = Console.ReadLine();
            Console.Write("Prix de l'article:");
            String artPrix = Console.ReadLine();
            Console.Write("Quantité initiale de l'article:");
            String artQtte = Console.ReadLine();
            Console.Write("Type de l'article:");
            String artType = Console.ReadLine();

            Article handWritten = new Article(artName, Convert.ToDouble(artPrix), Convert.ToInt32(artQtte), (Article.Type)Enum.Parse(typeof(Article.Type),artType, true)) ;
            handWritten.Afficher();
        }
    }
}
