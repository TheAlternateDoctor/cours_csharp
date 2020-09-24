using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListeChainée
{
    class ListeEnumération: IEnumerator
    {
        private Liste _Liste;
        private int _indiceCourant;

        public object Current
        {
            get => _Liste[_indiceCourant];
        }

        public ListeEnumération(Liste liste)
        {
            _Liste = liste;
        }
        public bool MoveNext()
        {
            if(_Liste[_indiceCourant + 1] != null) 
            {
                _indiceCourant++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            _indiceCourant = 0;
        }
    }
}
