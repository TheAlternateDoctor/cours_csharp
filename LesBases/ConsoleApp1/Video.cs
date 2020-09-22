using System;
using System.Collections.Generic;
using System.Text;

namespace Unused
{
    class Video : Article
    {
        protected float duree; //En mn

        public Video(float duree,String designation, int prix) : base(designation, prix)
        {
            this.duree = duree;
        }

        public void Afficher()
        {
            Console.WriteLine("Vous êtes en train de regarder " + designation + " d'une durée totale de " + duree + "mn.");
        }
    }
}
