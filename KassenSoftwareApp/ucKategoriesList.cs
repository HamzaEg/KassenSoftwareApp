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
    public partial class ucKategoriesList : UserControl
    {
        public ucKategoriesList()
        {
            InitializeComponent();
        }

        public List<vecProduct> productsfeeds
        {
            set
            {
                List<vecProduct> currentfeeds = value;

                this.flpKatList.Controls.Clear();
                List<string> katList = new List<string>();
                foreach (vecProduct item in currentfeeds)
                {
                    if (!katList.Contains(item.productKategorie)) {
                        katList.Add(item.productKategorie);
                        ucKategorie PKatItem = new ucKategorie();
                        PKatItem.PKategorie = item.productKategorie;
                        PKatItem.Tag = item;
                        PKatItem.Click += PKatItem_Click;
                        this.flpKatList.Controls.Add(PKatItem);
                    }
                }
            }
        }
        
        public delegate void productEvent(vecProduct product);
        public event productEvent pKatItemClick = delegate { };
        private void PKatItem_Click(object sender, EventArgs e)
        {
            //this.OnClick(e);

       
            this.pKatItemClick((vecProduct)((ucKategorie)sender).Tag );



            Console.WriteLine("ddddddddddddd");
        }
    }
}
