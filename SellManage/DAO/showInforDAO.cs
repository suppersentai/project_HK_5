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
        public static DataTable takeListType()
        {
            String sql = "select tenloai from loaisanpham ";
            DataTable dtableType = ConnectDAO.getDataTable(sql);
            if (dtableType.Rows.Count == 0)
            {
                MessageBox.Show("base base loaisanpham null ");
                return null;
            }
          
            return dtableType;
        }

        public static DataTable takeListSize()
        {
            
            List<product> list = new List<product>();
            String sql = "select (size) from SANPHAM group by size order by size;";
            DataTable dtableSize = ConnectDAO.getDataTable(sql);
            if (dtableSize.Rows.Count == 0)
            {
                return null;
            }
            return dtableSize;
        }
        public static DataTable takeListColor()
        {
          

            List<product> list = new List<product>();
            String sql = "select (mausac) from SANPHAM group by MAUSAC order by mausac;";
            DataTable dtableSize = ConnectDAO.getDataTable(sql);
            if (dtableSize.Rows.Count == 0)
            {
                MessageBox.Show("data table = null  chung toan say: takeListColorDAO");
                return null;
               
            }
            return dtableSize;
        }
        public static DataTable getListProduct()
            
        {
          
            List<product> list = new List<product>();
            //try
            //{
                string sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap; ";

                DataTable dtableProduct = ConnectDAO.getDataTable(sql);
          
                //if (dtableProduct.Rows.Count == 0)
                //{
                //    return null;
                //}
                //else

                //{
                   
                  

                //        for (int i = 0; i < dtableProduct.Rows.Count; i++)
                //        {
                //           product pro = new product();
                //            pro.Id = int.Parse(dtableProduct.Rows[i]["idSP"].ToString());
                //            pro.Name = dtableProduct.Rows[i]["tenSP"].ToString();
                //            pro.Type = dtableProduct.Rows[i]["tenLoai"].ToString();
                //            pro.Size = dtableProduct.Rows[i]["size"].ToString();
                //            pro.Color = dtableProduct.Rows[i]["MauSac"].ToString();
                //            pro.Supplies = dtableProduct.Rows[i]["tenncc"].ToString();

                //            pro.OutPrice = double.Parse(dtableProduct.Rows[i]["GiaBan"].ToString());
                //            pro.Note = dtableProduct.Rows[i]["note"].ToString();
                //             pro.Tag = dtableProduct.Rows[i]["TenLoai"].ToString();

                //        list.Add(pro);
                
                //    }
                // }
       
           
         
            //}
            //   catch (Exception e)
            //    {
            //         MessageBox.Show(e.StackTrace.ToString());
            //    }
          

            return dtableProduct;
        }
        public static DataTable filterCombox(String type, String size, String color)
        {
            DataTable data = null;
            MessageBox.Show(type+" -- "+size+"--"+color);
            if (color != null) { 
                String sql = " select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP = hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC = sanpham.IdNhaCungCap and mausac ='"+color+ "' and idloai ='" + int.Parse(type) + "' and size='"+size+"'; ";
            }
            MessageBox.Show("Toan 222222");
            return data;
        }
    }
}
