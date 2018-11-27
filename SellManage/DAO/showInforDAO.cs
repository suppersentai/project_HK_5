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

        public static List<product> takeListSize()
        {
            List<product> list = new List<product>();
            String sql = "select idProduct, sizeProduct  from tbl_product";
            DataTable dtableSize = ConnectDAO.getDataTable(sql, ConnectDAO.getConnect());

            if (dtableSize.Rows.Count == 0)
            {
                return null;

            }
            else
            {
                //tao list<type product> nhung chi lay id  and size
                

                for (int i = 0; i < dtableSize.Rows.Count; i++)
                {
                    product pro = new product();

                    pro.Id = int.Parse(dtableSize.Rows[i]["idProduct"].ToString());

                    pro.Size = Convert.ToInt32(dtableSize.Rows[i]["sizeProduct"]);

                    list.Add(pro);
                  
                }
              
            }
            return list;
        }
        public static List<product> takeListColor()
        {
            List<product> list = new List<product>();
            String sql = "select colorProduct  from tbl_product";
            DataTable dtableSize = ConnectDAO.getDataTable(sql, ConnectDAO.getConnect());

            if (dtableSize.Rows.Count == 0)
            {
                return null;

            }
            else
            {
                //tao list<type product> nhung chi lay id  and size


                for (int i = 0; i < dtableSize.Rows.Count; i++)
                {
                    product pro = new product();
                    pro.Color =dtableSize.Rows[i]["colorProduct"].ToString();

                    list.Add(pro);
                }

            }
            return list;
        }
        public static List<product> getListProduct()
            
        {
          
            List<product> list = new List<product>();
            try
            {
                string sql = "select SANPHAM.* ,LOAISANPHAM.tenLoai,giaban from SANPHAM, LOAISANPHAM ,HoaDonNhapHang where SANPHAM.idLOAISANPHAM = LOAISANPHAM.id and sanpham.id=hoadonnhaphang.IdSanPham; ";

                DataTable dtableProduct = ConnectDAO.getDataTable(sql, ConnectDAO.getConnect());
          
                if (dtableProduct.Rows.Count == 0)
                {
                    return null;
                }
                else

                {
                   
                  

                        for (int i = 0; i < dtableProduct.Rows.Count; i++)
                        {
                           product pro = new product();
                            pro.Id = int.Parse(dtableProduct.Rows[i]["id"].ToString());
                            pro.Name = dtableProduct.Rows[i]["ten"].ToString();
                            pro.Type = dtableProduct.Rows[i]["IdLoaiSanPham"].ToString();
                            pro.Size = int.Parse(dtableProduct.Rows[i]["size"].ToString());
                            pro.Color = dtableProduct.Rows[i]["MauSac"].ToString();
                            pro.OutPrice = double.Parse(dtableProduct.Rows[i]["GiaBan"].ToString());
                            pro.Note = dtableProduct.Rows[i]["note"].ToString();
                             pro.Tag = dtableProduct.Rows[i]["TenLoai"].ToString();

                        list.Add(pro);
                
                    }
                 }
       
             
         
            }
               catch (Exception e)
                {
                     MessageBox.Show(e.StackTrace.ToString());
                }
          

            return list;
        }
        public static DataTable filterCombox(String type, String size, String color)
        {
            DataTable data = null;
           // String sql = ConnectDAO.getDataTable
            return data;
        }
    }
}
