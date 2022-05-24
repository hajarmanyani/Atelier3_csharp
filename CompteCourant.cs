using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_3
{
    class CompteCourant : Compte
    {
        private Devise Decouvert;
        private int numcarte;
        public CompteCourant() { }
        public CompteCourant(Devise d, Client c, Devise dec,int numcarte) : base(d, c)
        {
            this.Decouvert = dec;
            this.numcarte = numcarte;
        }
        public override bool Retirer(Devise d)
        {
            if (this.mt - d >= this.Decouvert)
            {
                return base.Retirer(d);
            }
            return false;
        }
    }
}
