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
    static    String stringConnect = "Data Source = localhost;Database = quanlibanhang; port = 3306;User Id=root;password=;charset=utf8;";

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
        public static bool queryNonQuery(String stringQuery)
        {
            MySqlConnection conn = null;
            try
            {
                using ( conn = new MySqlConnection(stringConnect))
                {

                    conn.Open();
                    MySqlCommand command = new MySqlCommand(stringQuery, conn);
                    if(command.ExecuteNonQuery()>=1)
                        //  conn.Close();
                        return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + "\n ChungToan Say connectDAO/queryNonQuery");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public static int getDataIDBill(String stringQuery)
        {
            using (MySqlConnection conn = new MySqlConnection(stringConnect))
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand(stringQuery, conn);
                MySqlDataReader adapter = com.ExecuteReader();
                adapter.Read();

                int num = Convert.ToInt32(adapter[0].ToString());
                conn.Close();
                return num ;
            }

        }
       


    }
}
