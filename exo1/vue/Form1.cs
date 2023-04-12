using exo1.vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo1
{
    public partial class Form1 : Form
    {
        List<Voyage> listVoyage = new List<Voyage>();


        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("data"))
            {
            listVoyage = Serialise.chargement();

            }
            else
            {
                Voyage unVoyage = new Voyage("Bali", 1800, 20, new Date(15, 02, 2022), new Date(29, 09, 2022), 25);
                Voyage unAutreVoyage = new Voyage("Paris", 800, 30, new Date(27, 05, 2023), new Date(18, 07, 2024), 30);

                listVoyage.Add(unVoyage);
                listVoyage.Add(unAutreVoyage);

            }
            
            listBox1.DataSource = listVoyage;
            groupBox1.Visible = false;
          


         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelArr.Text = listVoyage[listBox1.SelectedIndex].getArrive().ToString();
            labelDep.Text = listVoyage[listBox1.SelectedIndex].getDepart().ToString();
            labelDes.Text = listVoyage[listBox1.SelectedIndex].getDestination();
            labelPlaceDispo.Text = listVoyage[listBox1.SelectedIndex].getNbPlacesDispos().ToString();
            labelPrix.Text = listVoyage[listBox1.SelectedIndex].getPrix().ToString();
            groupBox1.Visible = true;
        }

        private void reserverBtn_Click(object sender, EventArgs e)
        {
            Resa laReservation = new Resa(listVoyage[listBox1.SelectedIndex], Convert.ToInt32(nbPersChoisi.Text));
            if (laReservation.resaPossible())
            {
                ConfirmForm comfirmerResa = new ConfirmForm(laReservation);
                comfirmerResa.ShowDialog();
            }
            else
            {
                var NbPersonnesError = new ErrorForm();
                NbPersonnesError.Show();
                this.Refresh();
            }
        }

        private void labelPrix_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialise.sauvegarde(listVoyage);
        }
    }
}
