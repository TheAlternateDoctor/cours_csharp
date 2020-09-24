using System;
using System.Collections.Generic;
using System.Text;

namespace LinqArticles
{
    public interface IArticleDAO
    {
        List<Article> GetArticles();
        (int, int) GetDesignationAndPrix(String designation);
        Tuple<int, int> GetDesignationAndPrixTuple(String designation);

        Tuple<Article,Article,double> GetMinMaxMoyenArticle();
    }
}
