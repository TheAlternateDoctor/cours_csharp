using System;
using System.Collections.Generic;
using System.Text;

namespace Unused
{
    class Poche : Livre
    {
        private String categorie;
        public Poche(int isbn, String designation, int nbPages, int prix, String categorie): base(isbn, designation, nbPages, prix)
        {
            this.categorie = categorie;
        }
    }
}
