using System;
using System.Collections.Generic;
using System.Text;

namespace Unused
{
    class Livre : Article
    {
        protected int isbn;
        protected int nbPages;

        protected Livre(int isbn,String designation, int nbPages, int prix): base(designation, prix)
        {
            this.isbn = isbn;
            this.nbPages = nbPages;
        }
    }
}
