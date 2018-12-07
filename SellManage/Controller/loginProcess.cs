using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;

namespace Controller
{
    public class loginProcess
    {
        public  bool checkInvalid(String name, String password)
        {
            string regex = "\\w{6,30}";
            Regex.IsMatch(name, regex);
            if (Regex.IsMatch(name, regex) || Regex.IsMatch(password, regex)) {
                return true;
            }
            return false;
        }
        public bool checkExistAccount(String name, String password)
        {
            if (DAO.userDAO.checkExistAccount(name,password))
                return true;
            return false;
        }
        public static staff getAccount(String name, String password)
        {
            DataTable data = DAO.userDAO.getAccount(name,password);
            staff st = new staff();
            st.Id = Convert.ToInt32( data.Rows[0]["idnv"].ToString());

            st.Name = data.Rows[0]["tennv"].ToString();
            st.UserName = data.Rows[0]["username"].ToString();
            st.Password= data.Rows[0]["pass"].ToString();
            st.CheckAdmin= Convert.ToInt32(data.Rows[0]["checkadmin"].ToString());
            return st;
        }
    }
}
