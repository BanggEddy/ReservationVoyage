using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo1.vue
{
    internal partial class ConfirmForm : Form
    {
        List<Voyage> listVoyage = new List<Voyage>();

        private Resa laReservation;

        public ConfirmForm(Resa laReservation)
        {
            InitializeComponent();

            this.laReservation = laReservation;
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            labelArr.Text = laReservation.leVoyage.getArrive().ToString();
            labelDep.Text = laReservation.leVoyage.getDepart().ToString();
            labelDes.Text = laReservation.leVoyage.getDestination();
            labelPassagers.Text = laReservation.nbPersonnes.ToString();
            labelPlaceDispo.Text = laReservation.leVoyage.getNbPlacesDispos().ToString();
            labelMontant.Text = laReservation.calculMontant().ToString() + " €";
            Serialise.sauvegarde(listVoyage);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelDep_Click(object sender, EventArgs e)
        {

        }

        private void labelArr_Click(object sender, EventArgs e)
        {

        }

        private void labelPlaceDispo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            laReservation.comfirmResa();

            this.Close();
        }

        private void labelDes_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
