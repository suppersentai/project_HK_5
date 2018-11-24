using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAO
{
    public   class ConnectDAO
    {
        public static  MySqlConnection getConnect()
        {
            String stringConnect = "Data Source = localhost;Database = managesell; port = 3306;User Id=root;password=";
            MySqlConnection conn = new MySqlConnection(stringConnect);
            return conn;
        }
        public static void test()
        {

         
                MessageBox.Show("ok thah con", "thong bao");
          
        }
    }
}
