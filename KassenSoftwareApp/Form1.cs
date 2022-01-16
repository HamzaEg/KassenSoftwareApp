using System;
using System.Collections;
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
    public partial class Form1 : Form
    {

        //private List<string> listOfAllItems = new List<string>();
       

        private List<vecProduct> productsfeeds = new List<vecProduct>();
        public Form1()
        {
            InitializeComponent();




            lbPonList.Items.Add("QTY    |PRICE  |Product Name  ");
            lbPonList.Items.Add("-----------------------------------");

            Datasources.daten datenquelle = new Datasources.clsMySQL();
            this.productsfeeds = datenquelle.holeDaten();
            if (productsfeeds == null) {
                ucProductsList1.Controls[0].BackColor = Color.DarkGray;

                productsfeeds = new List<vecProduct>();
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Notebooks", "2659358", "LENOVO IdeaPad 3, Notebook mit 15,6 Zoll Display, Core™ i5 Prozessor, 8 GB RAM, 512 GB SSD, Intel UHD Grafik, Platinsilber", "PC", float.Parse("548,81")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Ultrabooks", "2674775", "ACER Swift 3 (SF313-52G-71YX) Tastaturbeleuchtung, Notebook mit 13,5 Zoll Display, Core™ i7 Prozessor, 16 GB RAM, 1 TB SSD, GeForce MX350, Aluminium/Silber", "PC", float.Parse("1198,02")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Apple MacBook", "2616169", "APPLE MVVK2D/A MacBook Pro, Notebook mit 16 Zoll Display, Core™ i9 Prozessor, 16 GB RAM, 1 TB SSD, AMD Radeon Pro 5500M, Space Grey", "PC", float.Parse("2823,74")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Gaming-Notebooks", "2698319", "RAZER Blade Stealth 13 OLED Touch Display, Gaming Notebook mit 13,3 Zoll Display Touchscreen, Core™ i7 Prozessor, 16 GB RAM, 512 GB SSD, GeForce® GTX 1650 Ti Max Q Design, Schwarz", "PC", float.Parse("2247,75")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Netbooks", "2618137", "LENOVO IdeaPad Slim 1, Notebook mit 11,6 Zoll Display, A6 Prozessor, 4 GB RAM, 64 GB eMMC, Radeon R4, Platinum Grey", "PC", float.Parse("243,69")));

                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "Tastaturen", "2048835", "MICROSOFT Wireless Desktop 900, Tastatur-Maus Set, Schwarz", "RAM", float.Parse("34,66")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "PC Mäuse", "2515357", "ISY IMW-501 Funkmaus, Schwarz", "RAM", float.Parse("6,81")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "USB-Zubehör", "2496611", "GOOBAY USB 2.0 Hi-Speed Verlängerungskabel", "RAM", float.Parse("1,69")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "PC Lautsprecher", "1704168", "BOSE Companion 2 Serie III PC-Lautsprecher", "RAM", float.Parse("75,37")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "Webcams", "2697699", "CONCEPTRONIC AMDIS 1080P Full HD - Webcam", "RAM", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "2674928", "SAMSUNG TAB A7 Wi-Fi, Tablet, 32 GB, 10,4 Zoll, Silber", "Tablet", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "254617", "APPLE iPad mini (2019) WiFi, Tablet, 64 GB, 7,9 Zoll, Gold", "Tablet", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "254612", "AMAZON Fire 7, Tablet, 16 GB, 7 Zoll, Schwarz", "Tablet", float.Parse("38,98")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "254613", "Festplatte 2TB SSD", "Tablet", float.Parse("19,99")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "2697699", "CONCEPTRONIC AMDIS 1080P Full HD - Webcam", "Tablet", float.Parse("49,99")));

                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "Monitor", "254616", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "HP 15750", "254617", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "Monitor", "254616", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "HP 15750", "254617", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "Monitor", "254616", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "HP 15750", "254617", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "Monitor", "254616", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "HP 15750", "254617", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Monitore", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "Monitore", float.Parse("105,50")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "Monitor", "254616", "Festplatte 250GB SSD", "Monitore", float.Parse("120")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "HP 15750", "254617", "Festplatte 250GB SSD", "Monitore", float.Parse("150")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "Monitor", "254616", "Festplatte 250GB SSD", "Monitore", float.Parse("175")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "HP 15750", "254617", "Festplatte 250GB SSD", "Monitore", float.Parse("225")));

                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "Monitor", "254616", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "HP 15750", "254617", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "Monitor", "254616", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "HP 15750", "254617", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));


            }
            else if (productsfeeds.Count == 0)
            {
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Notebooks", "2659358", "LENOVO IdeaPad 3, Notebook mit 15,6 Zoll Display, Core™ i5 Prozessor, 8 GB RAM, 512 GB SSD, Intel UHD Grafik, Platinsilber", "PC", float.Parse("548,81")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Ultrabooks", "2674775", "ACER Swift 3 (SF313-52G-71YX) Tastaturbeleuchtung, Notebook mit 13,5 Zoll Display, Core™ i7 Prozessor, 16 GB RAM, 1 TB SSD, GeForce MX350, Aluminium/Silber", "PC", float.Parse("1198,02")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Apple MacBook", "2616169", "APPLE MVVK2D/A MacBook Pro, Notebook mit 16 Zoll Display, Core™ i9 Prozessor, 16 GB RAM, 1 TB SSD, AMD Radeon Pro 5500M, Space Grey", "PC", float.Parse("2823,74")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Gaming-Notebooks", "2698319", "RAZER Blade Stealth 13 OLED Touch Display, Gaming Notebook mit 13,3 Zoll Display Touchscreen, Core™ i7 Prozessor, 16 GB RAM, 512 GB SSD, GeForce® GTX 1650 Ti Max Q Design, Schwarz", "PC", float.Parse("2247,75")));
                this.productsfeeds.Add(new vecProduct(1, "Notebooks & Zubehör", "Netbooks", "2618137", "LENOVO IdeaPad Slim 1, Notebook mit 11,6 Zoll Display, A6 Prozessor, 4 GB RAM, 64 GB eMMC, Radeon R4, Platinum Grey", "PC", float.Parse("243,69")));

                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "Tastaturen", "2048835", "MICROSOFT Wireless Desktop 900, Tastatur-Maus Set, Schwarz", "RAM", float.Parse("34,66")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "PC Mäuse", "2515357", "ISY IMW-501 Funkmaus, Schwarz", "RAM", float.Parse("6,81")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "USB-Zubehör", "2496611", "GOOBAY USB 2.0 Hi-Speed Verlängerungskabel", "RAM", float.Parse("1,69")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "PC Lautsprecher", "1704168", "BOSE Companion 2 Serie III PC-Lautsprecher", "RAM", float.Parse("75,37")));
                this.productsfeeds.Add(new vecProduct(1, "PCs & Zubehör", "Webcams", "2697699", "CONCEPTRONIC AMDIS 1080P Full HD - Webcam", "RAM", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "2674928", "SAMSUNG TAB A7 Wi-Fi, Tablet, 32 GB, 10,4 Zoll, Silber", "Tablet", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "254617", "APPLE iPad mini (2019) WiFi, Tablet, 64 GB, 7,9 Zoll, Gold", "Tablet", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "254612", "AMAZON Fire 7, Tablet, 16 GB, 7 Zoll, Schwarz", "Tablet", float.Parse("38,98")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "254613", "Festplatte 2TB SSD", "Tablet", float.Parse("19,99")));
                this.productsfeeds.Add(new vecProduct(1, "Tablets & Zubehör", "Tablets", "2697699", "CONCEPTRONIC AMDIS 1080P Full HD - Webcam", "Tablet", float.Parse("49,99")));

                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "Monitor", "254616", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "HP 15750", "254617", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "Monitor", "254616", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Drucker & Scanner", "HP 15750", "254617", "Festplatte 250GB SSD", "printer", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "Monitor", "254616", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "HP 15750", "254617", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "Monitor", "254616", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Gaming & Gaming-Zubehör", "HP 15750", "254617", "Festplatte 250GB SSD", "GamingPC", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Monitore", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "Monitore", float.Parse("105,50")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "Monitor", "254616", "Festplatte 250GB SSD", "Monitore", float.Parse("120")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "HP 15750", "254617", "Festplatte 250GB SSD", "Monitore", float.Parse("150")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "Monitor", "254616", "Festplatte 250GB SSD", "Monitore", float.Parse("175")));
                this.productsfeeds.Add(new vecProduct(1, "Monitore", "HP 15750", "254617", "Festplatte 250GB SSD", "Monitore", float.Parse("225")));

                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "Monitor", "254616", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "HP 15750", "254617", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "Monitor", "254616", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Speichermedien", "HP 15750", "254617", "Festplatte 250GB SSD", "speichermedien", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Apple & Zubehör", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "Apple", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Apple & Zubehör", "Monitor", "254616", "Festplatte 250GB SSD", "Apple", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Apple & Zubehör", "HP 15750", "254617", "Festplatte 250GB SSD", "Apple", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Apple & Zubehör", "Monitor", "254616", "Festplatte 250GB SSD", "Apple", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Apple & Zubehör", "HP 15750", "254617", "Festplatte 250GB SSD", "Apple", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Software", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "Software", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Software", "Monitor", "254616", "Festplatte 250GB SSD", "Software", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Software", "HP 15750", "254617", "Festplatte 250GB SSD", "Software", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Software", "Monitor", "254616", "Festplatte 250GB SSD", "Software", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Software", "HP 15750", "254617", "Festplatte 250GB SSD", "Software", float.Parse("99,99")));

                this.productsfeeds.Add(new vecProduct(1, "Netzwerk", "atbeitspeicher", "254615", "Festplatte 500GB SSD", "Network", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Netzwerk", "Monitor", "254616", "Festplatte 250GB SSD", "Network", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Netzwerk", "HP 15750", "254617", "Festplatte 250GB SSD", "Network", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Netzwerk", "Monitor", "254616", "Festplatte 250GB SSD", "Network", float.Parse("99,99")));
                this.productsfeeds.Add(new vecProduct(1, "Netzwerk", "HP 15750", "254617", "Festplatte 250GB SSD", "Network", float.Parse("99,99")));

                datenquelle.schreibenDaten(this.productsfeeds);
                this.productsfeeds = datenquelle.holeDaten();

            }

            this.ucProductsList1.productsfeeds = productsfeeds;

            this.ucKategoriesList1.productsfeeds = productsfeeds;

            this.ucProductsList1.productClick += UcProductsList1_productClick;
            this.ucKategoriesList1.pKatItemClick += UcKategoriesList1_pKatItemClick;
            
            




        }

        private void UcKategoriesList1_pKatItemClick(vecProduct product)
        {
            ucProductsList1.Controls[0].Controls.Clear();

          

            List<vecProduct> ergebnis = this.productsfeeds.FindAll(a => a.productKategorie.Equals(product.productKategorie));

            foreach (vecProduct item in ergebnis)
            {
                ucProduct ucp = new ucProduct();
                ucp.PName = item.productName;
                ucp.PKategorie = item.productKategorie;
                ucp.Description = item.productDescription;
                ucp.PSN = item.productSN;
                ucp.PBildpath = item.ProductBildPath;
                ucp.PPrice = item.productPreis.ToString()+" €";
                ucp.Tag = item;
                ucp.Click += Ucp_Click;
                ucProductsList1.Controls[0].Controls.Add(ucp);
            }            
        }

        private void Ucp_Click(object sender, EventArgs e)
        {
            UcProductsList1_productClick((vecProduct)((ucProduct)sender).Tag);
        }

        private void UcProductsList1_productClick(vecProduct product)
        {
     
            frmCalc frmCalc = new frmCalc();
            
            frmCalc.StartPosition = FormStartPosition.Manual;
        



            frmCalc.Location = panel3.AccessibilityObject.Bounds.Location; 

            if (frmCalc.ShowDialog() == DialogResult.OK) {
              

                string anzahlString = frmCalc.anzahl.ToString();
                string preiceString = product.productPreis.ToString();
                string priceAnzahlString = (product.productPreis * frmCalc.anzahl).ToString();


                anzahlString = anzahlString.PadLeft(5);
                anzahlString = anzahlString.Replace(' ', '0');
                anzahlString = anzahlString.PadRight(7);

                preiceString = preiceString.PadLeft(5);
                preiceString = preiceString.Replace(' ', '0');
                preiceString = preiceString.PadRight(7);

                priceAnzahlString = priceAnzahlString.PadLeft(10);
                priceAnzahlString = priceAnzahlString.Replace(' ', '0');
                priceAnzahlString = priceAnzahlString.PadRight(12);

                string KassePonItem =anzahlString +"|" +  preiceString + "|" +  product.productName;

                //lbPonList.Items.Add(KassePonItem);
                if (frmCalc.anzahl != 0)
                {
                    lbPonList.Items.Add(KassePonItem);
                    //listOfAllItems.Add(KassePonItem);
                }
                
                //lbPonList.Items.Clear();

                //foreach (string item in lbPonList.Items)
                //{
                //    lbPonList.Items.Add(item);
                //}
                
                lblSumme.Text = (Math.Round(  float.Parse(lblSumme.Text) + frmCalc.anzahl * product.productPreis, 2)).ToString();



            }
        }

        private void btnLbPonListClear_Click(object sender, EventArgs e)
        {

            for (int i = lbPonList.Items.Count -1 ; i > 1; i--)
            {
                lbPonList.Items.RemoveAt(i);
            }
            



            Console.WriteLine(lbPonList.Items.Count);

            lblSumme.Text = "0";
        }

     

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            if (lbPonList.Items.Count > 2)
            { 
                string[] menus = null;

                if (lbPonList.SelectedItems.Count > 0 && lbPonList.SelectedIndex > 1)
                {
                    //string selectItem =  lbPonList.SelectedIndex.ToString();
                    //Console.WriteLine(selectItem);

                    Console.WriteLine("-------------->" + lbPonList.SelectedItem.ToString());
                   
                    menus = lbPonList.SelectedItem.ToString().Split('|');
                    Console.WriteLine(menus[0], menus[1], menus[2]);

                    

                    lblSumme.Text = (float.Parse(lblSumme.Text) - float.Parse(menus[0]) * float.Parse(menus[1])).ToString();
                    lblSumme.Text = Math.Round(float.Parse(lblSumme.Text),2).ToString();

                    lbPonList.Items.RemoveAt(lbPonList.SelectedIndex);

                    //  Console.WriteLine(lbPonList.SelectedItem.ToString() + "       index: " + lbPonList.SelectedIndex);
                }
                else
                {
                    Console.WriteLine("-------------->" + lbPonList.Items[lbPonList.Items.Count - 1]);
                    menus = lbPonList.Items[lbPonList.Items.Count - 1].ToString().Split('|');
                    Console.WriteLine(menus[0], menus[1], menus[2]);

                    lblSumme.Text = (float.Parse(lblSumme.Text) - float.Parse(menus[0]) * float.Parse(menus[1])).ToString();
                    lblSumme.Text = Math.Round(float.Parse(lblSumme.Text), 2).ToString();

                    lbPonList.Items.RemoveAt(lbPonList.Items.Count - 1);
                }
            }            
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            ucProductsList1.Controls[0].Controls.Clear();   
            ucNewProduct unp = new ucNewProduct();
            ucProductsList1.Controls[0].Controls.Add(unp);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void ucKategoriesList1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("this is the Form1");            
            //flowLayoutPanel1.Controls.Clear();


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void ucKategoriesList1_Load_1(object sender, EventArgs e)
        {

        }

        private void ucKategoriesList1_Load(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Datasources.daten datenquelle = new Datasources.clsMySQL();
            this.productsfeeds = datenquelle.holeDaten();

            ucProductsList1.Controls[0].Controls.Clear();
         
            foreach (vecProduct item in this.productsfeeds)
            {
                ucProduct ucp = new ucProduct();
                ucp.PName = item.productName;
                ucp.PKategorie = item.productKategorie;
                ucp.Description = item.productDescription;
                ucp.PSN = item.productSN;
                ucp.PBildpath = item.ProductBildPath;
                ucp.PPrice = item.productPreis.ToString() + " €";
                ucp.Tag = item;
                ucp.Click += Ucp_Click;
                ucProductsList1.Controls[0].Controls.Add(ucp);
            }
            ucKategoriesList1.Controls[0].Controls.Clear();
            this.ucKategoriesList1.productsfeeds = productsfeeds;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblProjektTime.Text = DateTime.Now.ToString();
            lblProjektTime.Location = new Point(lblProjektName.Location.X + lblProjektName.Width + 50, lblProjektName.Location.Y);



            if (lblProjektName.Location.X < panel2.Location.X - lblProjektName.Width - lblProjektTime.Width)
            {
                lblProjektName.Location = new Point(panel2.Location.X + panel2.Width, lblProjektName.Location.Y);
                
            }
            else
            {
                lblProjektName.Location = new Point(lblProjektName.Location.X - 1, lblProjektName.Location.Y);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
            ucProductsList1.Controls[0].Controls.Clear();
            foreach (vecProduct item in this.productsfeeds)
            {
                ucProduct ucp = new ucProduct();
                ucp.PName = item.productName;
                ucp.PKategorie = item.productKategorie;
                ucp.Description = item.productDescription;
                ucp.PSN = item.productSN;
                ucp.PBildpath = item.ProductBildPath;
                ucp.PPrice = item.productPreis.ToString() + " €";
                ucp.Tag = item;
                ucp.Click += Ucp_Click;
                ucProductsList1.Controls[0].Controls.Add(ucp);
            }
        }
    }
}
