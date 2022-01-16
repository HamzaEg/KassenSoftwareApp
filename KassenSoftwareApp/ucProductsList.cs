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
    public partial class ucProductsList : UserControl
    {
        public ucProductsList()
        {
            InitializeComponent();
        }


   
        public List<vecProduct> productsfeeds
        {
            set
            {
                List<vecProduct> currentfeeds = value;
                this.flpProductsflp.Controls.Clear();
                foreach (vecProduct item in currentfeeds)
                {
                    ucProduct PItem = new ucProduct();
                    PItem.PName = item.productName;
                    PItem.PSN = item.productSN;
                    PItem.PKategorie = item.productKategorie;
                    PItem.Description = item.productDescription;
                    PItem.PBildpath = item.ProductBildPath;
                    PItem.PPrice = item.productPreis.ToString() + " €";

                    PItem.Click += PItem_Click;
                    PItem.Tag = item;
                    this.flpProductsflp.Controls.Add(PItem);
                }
            }
        }

        public delegate void productEvent(vecProduct product);
        public event productEvent productClick = delegate { };
        private void PItem_Click(object sender, EventArgs e)
        {

            this.productClick((vecProduct)((ucProduct)sender).Tag );
        }

    }
}
