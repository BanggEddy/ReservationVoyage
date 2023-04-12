using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
   public class Resa
    {
        public Voyage leVoyage;
        public int nbPersonnes;

        public Resa(Voyage leVoyage, int nbPersonnes)
        {
            this.leVoyage = leVoyage;
            this.nbPersonnes = nbPersonnes;
        }




        public override string ToString()
        {
            return this.leVoyage.ToString() + "/" + this.nbPersonnes;
        }

        public double calculMontant()
        {
            return (this.leVoyage.getTaxe()*100/ this.leVoyage.getPrix() + this.leVoyage.getPrix()) * this.nbPersonnes;
        }

        public bool resaPossible()
        {
            return (this.nbPersonnes <= this.leVoyage.getNbPlacesDispos()) ? true : false;
        }

        public void comfirmResa()
        {
            this.leVoyage.modifNbPlacesDispos(this.nbPersonnes);
        }
    }
}
