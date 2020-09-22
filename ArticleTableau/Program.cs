using System;

namespace ArticleTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Article[] articles = new Article[4];
            articles[0] = new Article("Cassette type I", 1.5, 100, Article.Type.SUPPORT);
            articles[1] = new Article("Tape Deck CT-W208R", 50, 5, Article.Type.LECTEUR);
            articles[2] = new Article("MCD139B", 15, 20, Article.Type.ENCEINTES);
            foreach (Article article in articles)
                article.Afficher(); //Le dernier article (qui n'est pas initialisé ici) est initialisé avec 0 et "". Intéressant.

            Console.Write("Nom de l'article:");
            String artName = Console.ReadLine();
            Console.Write("Prix de l'article:");
            String artPrix = Console.ReadLine();
            Console.Write("Quantité initiale de l'article:");
            String artQtte = Console.ReadLine();
            Console.Write("Type de l'article:");
            String artType = Console.ReadLine();

            articles[3] = new Article(artName, Convert.ToDouble(artPrix), Convert.ToInt32(artQtte), (Article.Type)Enum.Parse(typeof(Article.Type), artType, true));
            articles[1].Ajouter(5);
            articles[0].Retirer(10);
            foreach (Article article in articles)
                article.Afficher();
        }
    }
}
