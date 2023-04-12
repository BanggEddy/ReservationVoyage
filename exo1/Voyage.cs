using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    [Serializable]
    public class Voyage
    {
        private string destination;
        private double prix, taxe;
        private Date dateDepart, dateArrive;
        private int nbPlacesDispos;

        public string getDestination()
        {
            return this.destination;
        }
        public Date getDepart()
        {
            return this.dateDepart;
        }
        public Date getArrive()
        {
            return this.dateArrive;
        }

        public double getPrix()
        {
            return this.prix;
        }
        public double getTaxe()
        {
            return this.taxe;
        }
        public int getNbPlacesDispos()
        {
            return this.nbPlacesDispos;
        }
        public void modifNbPlacesDispos(int placePrise)
        {
            this.nbPlacesDispos -= placePrise;
        }


        public Voyage(string destination, double prix, double taxe, Date dateDepart, Date dateRetour, int nbPlacesDispos)
        {
            this.destination = destination;
            this.prix = prix;
            this.taxe = taxe;
            this.dateDepart = dateDepart;
            this.dateArrive = dateRetour;
            this.nbPlacesDispos = nbPlacesDispos;
        }
        public override string ToString()
        {
            return "Pour: " + this.destination;
        }


    }
}
