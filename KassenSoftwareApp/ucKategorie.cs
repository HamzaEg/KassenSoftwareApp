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
    public partial class ucKategorie : UserControl
    {
        public ucKategorie()
        {
            InitializeComponent();
        }

        public string PKategorie
        {
            get { return this.lblKategorie.Text; }
            set { this.lblKategorie.Text = value; }
        }

        private void ucKategorie_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lblKategorie_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
