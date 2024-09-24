using Suivie_Facture.Class;
using Suivie_Facture.Frais_deplacement;
using Suivie_Facture.Frais_deplacement.CRY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture
{
    public partial class Home02 : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        public Home02()
        {
            InitializeComponent();
            //Variable.DynamicText = 1;
        }
        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);
                const int WM_NCPAINT = 0x85;
                if (m.Msg == WM_NCPAINT)
                {
                    IntPtr hdc = GetWindowDC(m.HWnd);
                    if ((int)hdc != 0)
                    {
                        Graphics g = Graphics.FromHdc(hdc);
                        g.FillRectangle(Brushes.Green, new Rectangle(0, 0, 4800, 23));
                        g.Flush();
                        ReleaseDC(m.HWnd, hdc);
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
           
        }
        public Home02(int n)
        {
            InitializeComponent();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var log = new Login2();
                log.Closed += (s, args) => this.Close();
                log.Show();
            }
            catch (Exception)
            {

                return;
            }
           
        }
        

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {
        }
        public void loadform(object Form)
        {
            try
            {
                if (this.pnl_main.Controls.Count > 0)
                    this.pnl_main.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.pnl_main.Controls.Add(f);
                this.pnl_main.Tag = f;
                f.Show();
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (Variable.GetRol.ToLower() == "admin" && Variable.UserName=="a.azmi")
                {
                    brToolStripMenuItem.Enabled = true;
                    aSSISTANTEDAFToolStripMenuItem.Enabled = true;
                    cHEFCOMPTABLEToolStripMenuItem.Enabled = true;
                    cOMPTABILITEToolStripMenuItem.Enabled = true;
                    aCHATToolStripMenuItem.Enabled = true;
                    cONSULTATIONToolStripMenuItem.Enabled = true;
                    bONLIVRASIONToolStripMenuItem.Enabled = true;
                    pARAMETRAGEToolStripMenuItem.Enabled = false;



                }
                else
                {
                    brToolStripMenuItem.Enabled = true;
                    aSSISTANTEDAFToolStripMenuItem.Enabled = true;
                    cHEFCOMPTABLEToolStripMenuItem.Enabled = true;
                    cOMPTABILITEToolStripMenuItem.Enabled = true;
                    aCHATToolStripMenuItem.Enabled = true;
                    cONSULTATIONToolStripMenuItem.Enabled = true;
                    bONLIVRASIONToolStripMenuItem.Enabled = true;
                    pARAMETRAGEToolStripMenuItem.Enabled = true;
                }
                if (Variable.GetRol.ToLower() == "br")
                {
                    loadform(new Form_BDR());
                    brToolStripMenuItem.Enabled = true;
                    aSSISTANTEDAFToolStripMenuItem.Enabled = false;
                    cHEFCOMPTABLEToolStripMenuItem.Enabled = false;
                    cOMPTABILITEToolStripMenuItem.Enabled = false;
                    aCHATToolStripMenuItem.Enabled = false;
                    cONSULTATIONToolStripMenuItem.Enabled = true;
                    bONLIVRASIONToolStripMenuItem.Enabled = false;
                    pARAMETRAGEToolStripMenuItem.Enabled = false;

                };
                if (Variable.GetRol.ToLower() == "cmp")
                {
                    loadform(new Form_CMP());
                    brToolStripMenuItem.Enabled = false;
                    aSSISTANTEDAFToolStripMenuItem.Enabled = false;
                    cHEFCOMPTABLEToolStripMenuItem.Enabled = false;
                    cOMPTABILITEToolStripMenuItem.Enabled = true;
                    aCHATToolStripMenuItem.Enabled = false;
                    cONSULTATIONToolStripMenuItem.Enabled = true;
                    bONLIVRASIONToolStripMenuItem.Enabled = false;
                    pARAMETRAGEToolStripMenuItem.Enabled = false;
                };
                if (Variable.GetRol.ToLower() == "achat")
                {
                    loadform(new Form_ACHAT());
                    brToolStripMenuItem.Enabled = false;
                    aSSISTANTEDAFToolStripMenuItem.Enabled = false;
                    cHEFCOMPTABLEToolStripMenuItem.Enabled = false;
                    cOMPTABILITEToolStripMenuItem.Enabled = false;
                    aCHATToolStripMenuItem.Enabled = true;
                    cONSULTATIONToolStripMenuItem.Enabled = true;
                    bONLIVRASIONToolStripMenuItem.Enabled = false;
                    pARAMETRAGEToolStripMenuItem.Enabled = false;


                  ;

                    button4_Click(sender, e);
                };
                if (Variable.GetRol.ToLower() == "ass")
                {
                    loadform(new Form_ASSDAF());
                    brToolStripMenuItem.Enabled = false;
                    aSSISTANTEDAFToolStripMenuItem.Enabled = true;
                    cHEFCOMPTABLEToolStripMenuItem.Enabled = false;
                    cOMPTABILITEToolStripMenuItem.Enabled = false;
                    aCHATToolStripMenuItem.Enabled = false;
                    cONSULTATIONToolStripMenuItem.Enabled = true;
                    bONLIVRASIONToolStripMenuItem.Enabled = false;
                    pARAMETRAGEToolStripMenuItem.Enabled = false;
                };
                if (Variable.GetRol.ToLower() == "chefcmp")
                {
                    loadform(new Form_ChefCMP());
                    brToolStripMenuItem.Enabled = false;
                    aSSISTANTEDAFToolStripMenuItem.Enabled = false;
                    cHEFCOMPTABLEToolStripMenuItem.Enabled = true;
                    cOMPTABILITEToolStripMenuItem.Enabled = false;
                    aCHATToolStripMenuItem.Enabled = false;
                    cONSULTATIONToolStripMenuItem.Enabled = true;
                    bONLIVRASIONToolStripMenuItem.Enabled = false;
                    pARAMETRAGEToolStripMenuItem.Enabled = false;
                };
            }
            catch (Exception)
            {

                return;
            }
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_BDR());
            }
            catch (Exception)
            {

                return;
            }
            
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ASSDAF());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_CMP());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ACHAT());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_consultation());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void btn_chefCMP_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ChefCMP());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void btn_prm_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new form_param());
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void btn_bl_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_BL());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void brToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void brToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             
            try
            {
                loadform(new Form_BDR());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void aSSISTANTEDAFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ASSDAF());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void cHEFCOMPTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ChefCMP());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void cOMPTABILITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_CMP());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void aCHATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ACHAT());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void cONSULTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_consultation());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void bONLIVRASIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pARAMETRAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                loadform(new form_param());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void sasirBonLivraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_BL());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void consultaionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    loadform(new Form_ConsultationBL());
            //}
            //catch (Exception)
            //{

            //    return;
            //}
        }

        private void gestionPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Imp_Personnel());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void gestionAnalytiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Imp_CodeAnalytique());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void gestionFraisDeplacementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Imp_FraisDeplacement());
            }
            catch (Exception)
            {

                return;
            }
        }

        private void etatAvancementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Etat_Avancement av = new Etat_Avancement();
                av.Show();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void etatFraisAntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imp_fraisANT ant = new imp_fraisANT();
            ant.Show();
        }

        private void etatParFraisCirculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FraisCirculation cr = new FraisCirculation();
            cr.Show();
        }

        private void etatDeProvisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FraisProvision pr = new FraisProvision();
            pr.Show();
        }

        private void etatParModeRégelementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FraisModRegelemnt md = new FraisModRegelemnt();
            md.Show();
        }
    }
}
