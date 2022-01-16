using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenSoftwareApp.Datasources {
    interface daten {

        List<vecProduct> holeDaten();
        void schreibenDaten(List<vecProduct> feeds);

    }
}