using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassenSoftwareApp
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        
        private void lblAnzahl_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void lblPlus_Click(object sender, EventArgs e)
        {
            lblAnzahl.Text = (Convert.ToInt32(lblAnzahl.Text) + 1).ToString();
        }

        private void lblMenus_Click(object sender, EventArgs e)
        {
            if (lblAnzahl.Text != "0")
            {
                lblAnzahl.Text = (Convert.ToInt32(lblAnzahl.Text) - 1).ToString();
            }
        }

        public int anzahl {
            get {return Convert.ToInt32(lblAnzahl.Text); }        
        }

        private void lblAnzahl_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    

        private void lblTen_Click(object sender, EventArgs e)
        {
            lblAnzahl.Text = (lblAnzahl.Text == "1" ? lblAnzahl.Text = "0" : lblAnzahl.Text = lblAnzahl.Text);

            lblAnzahl.Text = (Convert.ToInt32(lblAnzahl.Text) + 10).ToString();
        }

        private void lblFifty_Click(object sender, EventArgs e)
        {
            lblAnzahl.Text = (lblAnzahl.Text == "1" ? lblAnzahl.Text = "0" : lblAnzahl.Text = lblAnzahl.Text);

            lblAnzahl.Text = (Convert.ToInt32(lblAnzahl.Text) + 50).ToString();
        }

        private void lblHundred_Click(object sender, EventArgs e)
        {
            lblAnzahl.Text = (lblAnzahl.Text == "1" ? lblAnzahl.Text = "0" : lblAnzahl.Text = lblAnzahl.Text);

            lblAnzahl.Text = (Convert.ToInt32(lblAnzahl.Text) + 100).ToString();
        }

        private void lblZero_Click(object sender, EventArgs e)
        {
            lblAnzahl.Text = "0";
        }

        private void lblFive_Click(object sender, EventArgs e)
        {
            

            lblAnzahl.Text = (lblAnzahl.Text == "1" ? lblAnzahl.Text = "0" : lblAnzahl.Text = lblAnzahl.Text);


            lblAnzahl.Text = (Convert.ToInt32(lblAnzahl.Text) + 5).ToString();
        }

        private void lblXClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGrüßereMengen_Click(object sender, EventArgs e)
        {
          
        }
    }
}
