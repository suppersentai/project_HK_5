using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DAO
{
    class Program
    {

        public static MySqlConnection getConnect() 
        {
           
            String stringConnect = "Data Source = localhost; Database=managesell;Port=3306 ;User Id=QuyLe ;password=gaoTOAN1996";
            MySqlConnection conn = new MySqlConnection(stringConnect);
            return conn;
        }
      public void tam()
        {
            MySqlConnection c = null;
            c = getConnect();
            c.Open();
            // String sql = "insert into tbl_Staff (nameStaff,birthStaff,addressStaff,phoneStaff,hdldStaff) values('Truong chung toan', '1996/05/14', 'long binh -bien hoa -dong nai', 0333216636, 'hd333') ";

            String sql = "select * from tbl_Staff;";
            MySqlCommand com = new MySqlCommand(sql, c);

            MySqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {

                Console.WriteLine(rd[0] + "----" + rd[1] + "----" + rd[2] + "----" + rd[3].ToString() + "----" + rd[4] + "----" + rd[5]);
            }

            rd.Close();
            rd.Dispose();
            Console.Read();
        }

    }
}
