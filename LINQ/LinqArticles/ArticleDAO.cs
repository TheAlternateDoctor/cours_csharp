using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqArticles
{
    class ArticleDAO : IArticleDAO
    {
        public List<Article> articlesListe;
        public ArticleDAO()
        {
            articlesListe = Util.GetArticles();
        }
        public Article GetArticle(String designation)
        {
            return articlesListe.Where(art => art.designation.Equals(designation)).FirstOrDefault();
        }
        public List<Article> GetArticles()
        {
            return articlesListe;
        }

        public (int, int) GetDesignationAndPrix(string designation)
        {
            var res = articlesListe
                      .Where(art => art.designation.Equals(designation))
                      .Select(art => new { art.qtte, art.prix })
                      .FirstOrDefault();
            return (res.qtte, res.prix);
        }
        public Tuple<int, int> GetDesignationAndPrixTuple(string designation)
        {
            Tuple<int, int> res = articlesListe
                      .Where(art => art.designation.Equals(designation))
                      .Select(art => new Tuple<int, int>( art.qtte, art.prix ))
                      .FirstOrDefault();
            return res;
        }

        public Tuple<Article, Article, double> GetMinMaxMoyenArticle()
        {
            Article min = articlesListe
                .Where(art => art.qtte == articlesListe.Select(art => art.qtte).Min())
                .FirstOrDefault();
            Article max = articlesListe
                .Where(art => art.qtte == articlesListe.Select(art => art.qtte).Max())
                .FirstOrDefault();
            double moyenne = articlesListe.Select(art => art.prix).Average();
            return new Tuple<Article, Article, double>(min, max, moyenne);
        }
    }
}
