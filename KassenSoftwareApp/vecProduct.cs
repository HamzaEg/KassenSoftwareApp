using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenSoftwareApp
{
    public class vecProduct
    {

        public int productID;
        public string productKategorie = "";
        public string productName = "";
        public string productSN = "";
        public string productDescription = "";
        public string productbildpath = "";
        public float productPreis = 0;


        public vecProduct(int productID, string productKategorie, string productName, string productSN, string productDescription, string productbildpath, float productPreis )
        {
            this.productID = productID;
            this.productKategorie = productKategorie;
            this.productName = productName;
            this.productSN = productSN;
            this.productDescription = productDescription;
            this.productbildpath = productbildpath;
            this.productPreis = productPreis;
        }

        public double ProductID
        {
            get { return this.productID; }
        }

        public String ProductKategorie
        {
            
            set { this.productKategorie = value; }

        }
        public String ProductName
        {
        
            set { this.productName = value; }
            
        }
        public string ProductSN { get => this.productSN;
            set { this.productSN = value; }
        }

        public String ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }
        public String ProductBildPath
        {
            get { return this.productbildpath; }
            set { this.productbildpath = value; }
        }
        public double ProductPreis
        {
            get { return this.productPreis; }            
        }

    }


}
