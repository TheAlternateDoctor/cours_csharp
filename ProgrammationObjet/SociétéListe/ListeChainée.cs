using System;

namespace ListeChainée
{
    class Elément
    {
        private object _Objet;
        private Elément _Suivant;
        public object Objet
        {
            get => _Objet;
            set => _Objet = value;
        }
        public Elément Suivant
        {
            get => _Suivant;
            set => _Suivant = value;
        }

        public Elément(object objet)
        {
            _Objet = objet;
        }
    }

    class Liste
    {
        private Elément _Début;
        private int _NbEléments;

        public int NbEléments => _NbEléments;
        public object this[int index]
        {
            get {
                Elément elementToGet = _Début;
                for (int i = 0; i < index; i++)
                {
                    elementToGet = elementToGet.Suivant;
                }
                return elementToGet;
            }
        }

        public Liste()
        {
            _NbEléments = 0;
            _Début = null;
        }

        public void InsérerDebut(ref object element)
        {
            Elément débutPrécedent = _Début;
            _Début = new Elément(element);
            _Début.Suivant = débutPrécedent;
            _NbEléments++;
        }

        public void InsérerFin(ref object element)
        {
            if (_NbEléments == 0) { InsérerDebut(ref element); }
            else {
                Elément elementfinal = _Début;
                while(elementfinal.Suivant != null)
                {
                    elementfinal = elementfinal.Suivant;
                }
                elementfinal.Suivant = new Elément(element);
                _NbEléments++;
            }
        }

        public void Lister()
        {
            Elément elementCourant = _Début;
            while(elementCourant.Suivant != null)
            {
                Console.WriteLine(Convert.ChangeType(elementCourant.Objet, elementCourant.Objet.GetType()));
                elementCourant = elementCourant.Suivant;
            }
        }
    }
}
