using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture.Frais_deplacement.CRY
{
    public partial class FraisCirculation : Form
    {
        public FraisCirculation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etat = comboBox1.Text;
            imp_FraisCirculation nn = new imp_FraisCirculation(etat);
            nn.Show();
        }
    }
}
