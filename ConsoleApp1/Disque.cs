using System;
using System.Collections.Generic;
using System.Text;

namespace Unused
{
    class Disque : Article
    {
        protected String label;

        public Disque(String label, String designation, int prix) : base(designation,prix)
        {
            this.label = label;
        }

        public void Ecouter()
        {
            Console.WriteLine("Now playing - " + designation + " (Published by " + label + ")");
        }
    }
}
