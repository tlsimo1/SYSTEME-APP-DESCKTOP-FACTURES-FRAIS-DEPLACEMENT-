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
    public partial class FraisProvision : Form
    {
        public FraisProvision()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            imp_Prov imp_prov = new imp_Prov(date1, date2);
            imp_prov.Show();
        }
    }
}
