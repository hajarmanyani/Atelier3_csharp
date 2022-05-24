using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_3
{
    class CompteEpargne:Compte
    {
        private double tauxint;
        public CompteEpargne(Devise d, Client c, double ti) : base(d, c)
        {
            /*
            do{
                this.tauxint = Console.Read();
            }while( ti <0 && ti > 100)  
            */
            if (this.tauxint >= 0 && this.tauxint <= 100)
                this.tauxint = ti;
        }
        public override void afficher_compte()
        {
            base.afficher_compte();
            Console.WriteLine("Taux d'interet : " + this.tauxint);
        }

        public Devise InteretSolde(double taux)
        {
            Devise d = new Devise(taux / 100);
            return this.mt * d;

        }
        public override bool Retirer(Devise d)
        {
            if (d <= (this.mt / 2))
            {
                return base.Retirer(d + this.InteretSolde(this.tauxint));
            }
            return false;
        }
    }
}
