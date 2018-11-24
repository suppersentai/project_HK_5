using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace DAO
{
    public  class userDAO
    {
        public static bool checkInvalidDatabase(String name, String pass)
        {

            MySqlConnection conn = ConnectDAO.getConnect();
            conn.Open();
            
            String sql = "select * from tbl_user where userName='"+name+"' and pass='"+pass+"'";
            MySqlCommand com = new MySqlCommand(sql, conn);
            MySqlDataReader dataRead = com.ExecuteReader();
            if(dataRead.HasRows)
     return true;
            dataRead.Close();
            dataRead.Dispose();
            conn.Close();
            return false;
        }
   
    }
}
