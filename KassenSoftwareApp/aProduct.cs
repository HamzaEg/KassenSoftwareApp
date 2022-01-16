using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenSoftwareApp
{
    class aProduct
    {
        protected string pName = "";
        protected string pSerialNo = "";
        protected string pDescription = "";

        public aProduct(string pName, string pSerialNo, string pDescription)
        {
            this.pName = pName;
            this.pSerialNo = pSerialNo;
            this.pDescription = pDescription;
        }

        public String getPName() { return this.pName; }

        public String getPSerialNo() { return this.pSerialNo; }
        public String getPDescription() { return this.pDescription; }

    }
}

