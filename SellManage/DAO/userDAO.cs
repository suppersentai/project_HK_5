using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace DAO
{
    public  class userDAO
    {
        public static bool checkExistAccount(String name, String pass)
        {

            String sql = "select * from tbl_user where userName='"+name+"' and pass='"+pass+"'";
            DataTable da = ConnectDAO.getDataTable(sql);
         
            if(da.Rows.Count>0)
                return true;
            return false;
        }
   
    }
}
