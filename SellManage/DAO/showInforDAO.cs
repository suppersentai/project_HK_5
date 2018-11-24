using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MODEL;
using System.Data;


namespace DAO
{
    public class showInforDAO
    {
        public void fillCombobox(ComboBox type, ComboBox size, ComboBox color, ComboBox price)
        {

            MySqlConnection conn = ConnectDAO.getConnect();
            String sql = "select * from tbl_typeproduct";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader read;
            try
            {
                conn.Open();
            read   = comm.ExecuteReader();
                while (read.Read())
                {
                    type.Items.Add(read.GetValue(0).ToString());
                }
                 read.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.StackTrace);
            }

            String sql2 = "select sizeProduct,colorProduct,priceOutProduct from tbl_product";
            comm.CommandText = sql2;

            read = comm.ExecuteReader();
            bool check = false;
            bool check2 = false;
            while (read.Read())
            {
                if (check == false) { 
                    size.Items.Add(read.GetValue(0).ToString());
                    check = true;
                  }

                bool tam = false;
                foreach (var item in size.Items)
                {
                    if(read.GetValue(0).ToString() != item)
                    {
                        tam = true;break;
                       
                    }
                }
                if(tam == true)
                    size.Items.Add(read.GetValue(0).ToString());



                if (check2 == false)
                {
                    color.Items.Add(read.GetValue(1).ToString());
                    check2 = true;
                }
                tam = false;
                foreach (var item in color.Items)
                {
                    if (read.GetValue(1).ToString() != item)
                    {
                        tam = true; break;

                    }
                }
                if (tam == true)
                    color.Items.Add(read.GetValue(1).ToString());
            }

                conn.Close();
        }
        public void showDataGrid(DataGridView dataGridView)
        {
            MySqlConnection conn = ConnectDAO.getConnect();
            String sql= "select idProduct as N'Mã Sản phẩm',nameProduct,idType,sizeProduct,colorProduct,priceOutProduct,note from tbl_product";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable tableData = new DataTable();
            adapter.Fill(tableData);
            dataGridView.DataSource = tableData;
            conn.Close();
            adapter.Dispose();
        }
            
    }
}
