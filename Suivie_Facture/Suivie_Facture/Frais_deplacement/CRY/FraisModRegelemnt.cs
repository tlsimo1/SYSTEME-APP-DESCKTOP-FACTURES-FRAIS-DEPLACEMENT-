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
    public partial class FraisModRegelemnt : Form
    {
        public FraisModRegelemnt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string modeRegelemnt = cmb_modeReglement.Text;
            Imp_ModReg ModeReg = new Imp_ModReg(modeRegelemnt);
            ModeReg.Show();
        }
    }
}
