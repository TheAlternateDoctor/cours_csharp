using System;
using System.Collections.Generic;

namespace LinqArticles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice 3.4
            IArticleDAO articleDAO = new ArticleDAO();
            List<Article> articles  = articleDAO.GetArticles();

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }

            //Exercice 3.5
            (int qtte, int prix) = articleDAO.GetDesignationAndPrix("The Midnight - Monsters");
            Console.WriteLine();
            Console.WriteLine(qtte+" exemplaires "+prix+" eur\n");

            //Exercice 3.6
            Tuple<int, int> tupleArt = articleDAO.GetDesignationAndPrixTuple("FM-84 - Atlas");
            Console.WriteLine(tupleArt.Item1+ " exemplaires " + tupleArt.Item2 + " eur\n");

            //Exercice 3.7
            Tuple<Article, Article, double> tupleArtListe = articleDAO.GetMinMaxMoyenArticle();
            Console.WriteLine(tupleArtListe.Item1+ " min qtte\n " + tupleArtListe.Item2 + " max qtte\n"+ tupleArtListe.Item3+" eur en moyenne\n");
        }
    }
}
