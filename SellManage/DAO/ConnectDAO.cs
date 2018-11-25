using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace DAO
{
    public   class ConnectDAO
    {
        public static  MySqlConnection getConnect()
        {
            String stringConnect = "Data Source = localhost;Database = managesell; port = 3306;User Id=root;password=";
            MySqlConnection conn = new MySqlConnection(stringConnect);
            conn.Open();
            return conn;
        }
        public static DataTable getDataTable(String stringQuery,MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(stringQuery, conn);
            DataTable dataTable = new DataTable() ;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public static bool queryNonQuery(String stringQuery, MySqlConnection conn)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(stringQuery, conn);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                 return false;
            }
        }
      
    }
}
