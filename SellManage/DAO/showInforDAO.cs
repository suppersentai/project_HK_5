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
            String sql = "select * from loaisanpham ";
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
            String sql = "select (mausac) from SANPHAM group by mausac order by mausac;";
            DataTable dtable = ConnectDAO.getDataTable(sql);
            if (dtable.Rows.Count == 0)
            {
                return null;
            }
            return dtable;
        }
        public static DataTable getListProduct()
            
        {
          
            List<product> list = new List<product>();
 
                string sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap; ";

                DataTable dtableProduct = ConnectDAO.getDataTable(sql);
          
            return dtableProduct;
        }
        public static DataTable filterCombox(int idLoai)
        {
            DataTable data = null;
            string sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and idloaisanpham='"+idLoai+"'; ";
            data = ConnectDAO.getDataTable(sql);
            
            return data;
        }
    }
}
