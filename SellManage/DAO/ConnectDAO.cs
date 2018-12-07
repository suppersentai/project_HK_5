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
        static    String stringConnect = "server=localhost;user id=root;password=dong19599;persistsecurityinfo=True;database=quanlibanhang";

        //public static  MySqlConnection getConnect()
        //{
        //    MySqlConnection conn = new MySqlConnection();
        //    try
        //    {
        //        String stringConnect = "Data Source = localhost;Database = quanlibanhang; port = 3306;User Id=root;password=";
        //         conn = new MySqlConnection(stringConnect);
        //        conn.Open();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.StackTrace +"\n Error connect in getConnect()");
        //    }
        
        //    return conn;
        //}
        public static DataTable getDataTable(String stringQuery)
        {
            using (MySqlConnection conn = new MySqlConnection(stringConnect))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(stringQuery, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }

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
                MessageBox.Show(ex.StackTrace + "\n ChungToan Say connectDAO/queryNonQuery");
            }
            return false;
        }
      
    }
}
