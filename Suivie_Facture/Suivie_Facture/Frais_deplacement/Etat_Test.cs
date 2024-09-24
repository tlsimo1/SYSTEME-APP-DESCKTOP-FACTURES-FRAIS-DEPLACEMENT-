using Suivie_Facture.Frais_deplacement.CRY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture.Frais_deplacement
{
    public partial class Etat_Test : Form
    {
        public Etat_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etat = comboBox1.Text;
            imp_FraisCirculation nn = new imp_FraisCirculation(etat);
            nn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etat_Avancement av = new Etat_Avancement();
            av.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imp_fraisANT ant = new imp_fraisANT();
            ant.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string modeRegelemnt = cmb_modeReglement.Text;
            Imp_ModReg ModeReg = new Imp_ModReg(modeRegelemnt);
            ModeReg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            imp_Prov imp_prov = new imp_Prov(date1, date2);
            imp_prov.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
