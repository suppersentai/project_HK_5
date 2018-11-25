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
        public static List<typeProduct> takeListType()
        {
            //take list type from database
            List<typeProduct> list = new List<typeProduct>();

            String sql = "select * from tbl_typeProduct";
            DataTable dtableType = ConnectDAO.getDataTable(sql, ConnectDAO.getConnect());
            if (dtableType.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                //tao list<type product>
                for (int i = 0; i < dtableType.Rows.Count; i++)
                {
                   
                    typeProduct pro = new typeProduct();
                    pro.Id = dtableType.Rows[i]["idType"].ToString();
                    pro.Name = dtableType.Rows[i]["nameType"].ToString();
                    list.Add(pro);

                }
            }
            #region tam
            //MySqlConnection conn = ConnectDAO.getConnect();
            //String sql = "select * from tbl_typeproduct";
            //MySqlCommand comm = new MySqlCommand(sql, conn);
            //MySqlDataReader read;
            //try
            //{
            //    conn.Open();
            //read   = comm.ExecuteReader();
            //    while (read.Read())
            //    {
            //        type.Items.Add(read.GetValue(0).ToString());
            //    }
            //     read.Close();
            //}
            //catch (MySqlException e)
            //{
            //    MessageBox.Show(e.StackTrace);
            //}

            //String sql2 = "select sizeProduct,colorProduct,priceOutProduct from tbl_product";
            //comm.CommandText = sql2;

            //read = comm.ExecuteReader();
            //bool check = false;
            //bool check2 = false;
            //while (read.Read())
            //{
            //    if (check == false) { 
            //        size.Items.Add(read.GetValue(0).ToString());
            //        check = true;
            //      }

            //    bool tam = false;
            //    foreach (var item in size.Items)
            //    {
            //        if(read.GetValue(0).ToString() != item)
            //        {
            //            tam = true;break;

            //        }
            //    }
            //    if(tam == true)
            //        size.Items.Add(read.GetValue(0).ToString());



            //    if (check2 == false)
            //    {
            //        color.Items.Add(read.GetValue(1).ToString());
            //        check2 = true;
            //    }
            //    tam = false;
            //    foreach (var item in color.Items)
            //    {
            //        if (read.GetValue(1).ToString() != item)
            //        {
            //            tam = true; break;

            //        }
            //    }
            //    if (tam == true)
            //        color.Items.Add(read.GetValue(1).ToString());
            //}

            //    conn.Close();
            #endregion
            ConnectDAO.getConnect().Close();
            return list;
        }

        public static HashSet<int> takeListSize()
        {
            HashSet<int> list = new HashSet<int>();
            String sql = "select idProduct, sizeProduct  from tbl_product";
            DataTable dtableSize = ConnectDAO.getDataTable(sql, ConnectDAO.getConnect());

            if (dtableSize.Rows.Count == 0)
            {
                return null;

            }
            else
            {
                //tao list<type product> nhung chi lay id  and color
                for (int i = 0; i < dtableSize.Rows.Count; i++)
                {
                    product pro = new product();

                    pro.Id = int.Parse(dtableSize.Rows[i]["idProduct"].ToString());

                    pro.Size = Convert.ToInt32(dtableSize.Rows[i]["sizeProduct"]);

                    list.Add(pro.Size);
                  
                }
              
            }
            return list;
        }
        public static HashSet<String> takeListColor()
        {
            HashSet<String> list = new HashSet<String>();

            String sql = "select idProduct, colorProduct  from tbl_product";
            DataTable dtable = ConnectDAO.getDataTable(sql, ConnectDAO.getConnect());

            if (dtable.Rows.Count == 0)
            {
                return null;

            }
            else
            {
                //tao list<type product> nhung chi lay id  and color
                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                   String color = dtable.Rows[i]["colorProduct"].ToString();
                    list.Add(color);
                }

            }
            return list;
        }
        public static List<product> getListProduct()
            
        {
            //using (MySqlConnection conn = ConnectDAO.getConnect()){

            //String sql= "select idProduct as N'Mã Sản phẩm',nameProduct,idType,sizeProduct,colorProduct,priceOutProduct,note from tbl_product";
            //MySqlCommand comm = new MySqlCommand(sql, conn);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            //DataTable tableData = new DataTable();
            //adapter.Fill(tableData);
            //dataGridView.DataSource = tableData;
            //conn.Close();
            //adapter.Dispose();}
            List<product> list = new List<product>();

            String sql = "select tbl_product.*,nameType from tbl_product,tbl_typeProduct where tbl_product.idType = tbl_typeProduct.idType; ";
            DataTable dtableProduct = ConnectDAO.getDataTable(sql, ConnectDAO.getConnect());
     
            if (dtableProduct.Rows.Count == 0)
            {
                return null;
            }
            else

            {
                try
                {
                    for (int i = 0; i < dtableProduct.Rows.Count; i++)
                    {
                        product pro = new product();
                        pro.Id = int.Parse(dtableProduct.Rows[i]["idProduct"].ToString());
                        pro.Name = dtableProduct.Rows[i]["nameProduct"].ToString();
                        pro.Type = dtableProduct.Rows[i]["nameType"].ToString();
                        pro.Size = int.Parse(dtableProduct.Rows[i]["sizeProduct"].ToString());
                        pro.Color = dtableProduct.Rows[i]["colorProduct"].ToString();
                        pro.OutPrice = int.Parse(dtableProduct.Rows[i]["priceOutProduct"].ToString());
                        pro.Note = dtableProduct.Rows[i]["note"].ToString();
                        list.Add(pro);
                      
                    }
                }
                catch (Exception e)
                {
    MessageBox.Show(e.StackTrace.ToString());
                }
         
            }
            return list;
        }
            
    }
}
