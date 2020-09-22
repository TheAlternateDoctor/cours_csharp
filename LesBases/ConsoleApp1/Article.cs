using System;
using System.Collections.Generic;
using System.Text;

namespace Unused
{
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
            Console.WriteLine("Achat d'un "+ this.GetType().Name +" \"" + designation + "\" à " + prix + "euros acheté.");
        }
    }
}
