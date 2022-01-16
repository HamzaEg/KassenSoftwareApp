using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenSoftwareApp.Datasources {
    class clsMySQL : daten {
        private string host = "127.0.0.1";
        private string db = "kassensoftware";
        private string usr = "root";
        private string pwd = "";


        MySqlConnection conn = null;
        MySqlCommand cmd = null;

        /// <summary>
        /// Verbindungsherstellung und Basisinstallation der Tabellen
        /// </summary>

        public clsMySQL()
        {
            this.conn = new MySqlConnection("Server=" + host + ";Database=" + db + ";Uid=" + usr + ";Pwd=" + pwd + ";");
            try
            {
                this.conn.Open();
            string query = "CREATE TABLE  IF NOT EXISTS Products(" +
                "ProductId int NOT NULL AUTO_INCREMENT," +
                " PRIMARY KEY (ProductId)," +
                "ProductKategorie VARCHAR(35) NOT NULL," +
                "productName VARCHAR(25) NOT NULL," +
                "productSN VARCHAR(20) NOT NULL," +
                "productDescription VARCHAR(20) NOT NULL," +
                "productbildpath VARCHAR(20) NOT NULL," +
                "productPreis FLOAT );" +
                "";
            
            MySqlCommand cmd = new MySqlCommand(query, this.conn);

            cmd.ExecuteNonQuery();
            this.conn.Close();
            }
            catch (Exception)
            {

                //throw;
                
               
            }
           
        }

        public byte[] prepareUpload() {
            FileStream fs = new FileStream("bild.jpg", FileMode.Open, FileAccess.Read);
            byte[] byteImage = new byte[fs.Length];
            fs.Read(byteImage, 0, Convert.ToInt32(fs.Length)); // ab 0 byte anfangen, fs.Length ist Long
            fs.Close();
            return byteImage;
        }

        /// <summary>
        /// Schreibt alle Elemente der übergebenen Liste in die Datenbank (als Datenzeilen)
        /// </summary>
        /// <param name="feeds">Zu schreibende Liste vom Typ vecNewsfeed</param>
        public void schreibenDaten(List<vecProduct> feeds) {
            this.conn.Open();
             
            
            foreach (vecProduct item in feeds)
            {
                //string query = " INSERT INTO products(ProductKategorie, productName, productSN, productDescription, productbildpath, productPreis) VALUES('Drucker', 'HP 15750', '254617', 'Festplatte 250GB SSD', 'printer', 600); ";
   
                

                string query = " INSERT INTO products(ProductKategorie, productName, productSN, productDescription, productbildpath, productPreis) VALUES" +
                    "('"+item.productKategorie+"', '"+item.productName+ "', '" + item.productSN + "', '" + item.productDescription + "', '" + item.productbildpath + "', " + item.productPreis.ToString().Replace(',','.') + "); ";
                MySqlCommand cmd = new MySqlCommand(query, this.conn);
                //cmd.Parameters.AddWithValue("@bild", this.prepareUpload());
                cmd.ExecuteNonQuery();
            }

            this.conn.Close();
            //conn.Open();
            //String ins = "INSERT INTO feeds(Kategorie, Titel, Inhalt, Datum) VALUES ('News1', 'Leipzig1', 'Leipzig ist schön1', '02.01.2020')";
            //SqlCommand newdata = new SqlCommand(ins, conn);
            //newdata.Parameters.Add("'News1', 'Leipzig1', 'Leipzig ist schön1', '02.01.2020'", System.Data.SqlDbType.VarChar);
            //newdata.ExecuteNonQuery();
            //conn.Close();
        }

        //private Image streamPicture(MySqlDataReader reader) {
        //    MemoryStream ms = new MemoryStream();
        //    BinaryWriter bw = new BinaryWriter(ms);

        //    int bufferSize = 100;
        //    byte[] outbyte = new byte[bufferSize];
        //    int startIndex = 0; 
        //    long retval = reader.GetBytes(4, startIndex, outbyte, 0, bufferSize); 

        //        while(retval == bufferSize) {
        //            bw.Write(outbyte);
        //            bw.Flush();

        //            startIndex += 100;
        //        retval = reader.GetBytes(4, startIndex, outbyte, 0, bufferSize);
        //        }

        //        if (retval >= 0) {
        //            bw.Write(outbyte, 0, (int)retval); 
        //            bw.Flush();
        //        }

        //    Image img = new Bitmap(ms);
        //    return img;
        //}

        /// <summary>
        /// Bezieht alle Datenzeilen und gibt diese als generische Liste zurück
        /// </summary>
        /// <returns>Generische Liste vom Typ vecNewsfeed</returns>
        public List<vecProduct> holeDaten() {
            String hole = "SELECT * FROM Products;";
          
            this.cmd = new MySqlCommand(hole, (MySqlConnection)this.conn);
            try
            {
     this.conn.Open();
            MySqlDataReader smdr = this.cmd.ExecuteReader();
            List<vecProduct> daten = new List<vecProduct>();
            while (smdr.Read()) {
                ////Image img = this.streamPicture(smdr);
                Console.WriteLine( float.Parse(smdr.GetString(6)));
                daten.Add(new vecProduct(Convert.ToInt32(smdr.GetString(0)), smdr.GetString(1), smdr.GetString(2), smdr.GetString(3), smdr.GetString(4), smdr.GetString(5), smdr.GetFloat(6)));                
            }
            smdr.Close();

            this.conn.Close();
            return daten;
            }
            catch (Exception)
            {

                //throw;                
                return null;
                
            }
       

        }
    }
}
