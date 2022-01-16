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
    public partial class ucNewProduct : UserControl
    {
        private List<vecProduct> productsfeeds = new List<vecProduct>();
        public ucNewProduct()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Datasources.daten datenquelle = new Datasources.clsMySQL();
            //this.productsfeeds.Add(new vecProduct(1, cbCategorie.Text, txtProdName.Text, txtSeriaNo.Text, txtDescription.Text, cbImages.Text, float.Parse(txtPrice.Text)));
            //datenquelle.schreibenDaten(this.productsfeeds);
            this.OnClick(e);
        }
    }
}
