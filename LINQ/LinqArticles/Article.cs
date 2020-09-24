using System;
using System.Collections.Generic;
using System.Text;

namespace LinqArticles
{
    public class Article
    {
        public String designation { get; }
        public int prix { get; }
        public int qtte { get; }

        public Article(String designation, int prix, int qtte)
        {
            this.designation = designation;
            this.prix = prix;
            this.qtte = qtte;
        }

        public void Acheter()
        {
            Console.WriteLine("Achat d'un " + this.GetType().Name + " \"" + designation + "\" à " + prix + "euros acheté.");
        }

        public override String ToString() => "Article \"" + designation + "\" à " + prix + " euros, qtte="+qtte;
    }
}
