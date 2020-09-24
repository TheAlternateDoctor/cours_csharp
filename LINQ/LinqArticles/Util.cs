using System;
using System.Collections.Generic;
using System.Text;

namespace LinqArticles
{
    public class Util
    {
        public static List<Article> GetArticles()
        {
            List<Article> article = new List<Article>()
            {
                new Article("The Midnight - Monsters",10,250),
                new Article("FM-84 - Atlas",15,80),
                new Article("Ollie Wride - Thanks in Advance",12,3),
                new Article("Robert Parker - Club 707",8,35)
            };
            return article;
        }
    }
}
