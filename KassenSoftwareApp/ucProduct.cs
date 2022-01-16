using KassenSoftwareApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassenSoftwareApp
{
    public partial class ucProduct : UserControl
    {
       
        
        public ucProduct()
        {
            InitializeComponent();
        }

        public string PKategorie
        {
            get { return this.lblKategorie.Text; }
            set { this.lblKategorie.Text = value; }
        }

        public string PName {
            get { return this.lblProductName.Text; }
            set { this.lblProductName.Text = value; }
        }
        public string PSN
        {
            set { this.lblProductSN.Text = value; }
        }

        public String Description
        {
            set { this.lblDescription.Text = value; }
        }
        public String PBildpath
        {
            set {
                ResourceManager rm = Resources.ResourceManager;
                Bitmap myImage = (Bitmap)rm.GetObject(value);
                this.picProductBild.Image = myImage; }            
        }

        public String PPrice
        {
            set { this.lblPrice.Text = value; }
        }

      

        private void picProductBild_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
