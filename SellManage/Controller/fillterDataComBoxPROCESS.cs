using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace Controller

{
    public class fillterDataComBoxPROCESS
    {
        public DataTable fillterTypeCombox(String size, int idType, string color)
        {
            String sql = null;
            DataTable data = null;
            //if (idType == 0)
            //{
            //    sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and mausac='" + color + "' size='" + size + "'; ";

            //}
            if (idType == 0)
            {
                if (color != null && size == null)
                {
                    sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and mausac='" + color + "'; ";
                    MessageBox.Show("th1");
                }
                else
                    if (size != null && color == null)
                {
                    sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and size='" + size + "'and idloaisanpham='" + idType + "'; ";
                    MessageBox.Show("th2");
                }
                else
                {
                    sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and size='" + size + "' and mausac='" + color + "'; ";
                    MessageBox.Show("th3");
                }

            } else
            {
                if (size != null && color == null)
                {
                    sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and idloaisanpham='" + idType + "' and size='" + size + "'  ; ";
                    MessageBox.Show("th4");
                } else if (size == null && color != null)
                {
                    sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and idloaisanpham='" + idType + "' and mausac='" + color + "'  ; ";
                    MessageBox.Show("th5");
                }
                else if (size != null && color != null)
                {
                    sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and idloaisanpham='" + idType + "'and mausac='" + color + "' and size='" + size + "' ; ";
                    MessageBox.Show("ca 3 khac null");
                }
            }
      


            if (idType == 0 && size == null)
            {
              
            }
            else if (idType == 0 && color == null)
            {
                sql = "select SANPHAM.idSp ,SANPHAM.tenSp,LOAISANPHAM.tenLoai,SANPHAM.size,SANPHAM.mausac,giaban,SANPHAM.doituongsudung,SANPHAM.note from SANPHAM, LOAISANPHAM ,HoaDonNhapHang,nhacungcap where SANPHAM.idLOAISANPHAM = LOAISANPHAM.idLoai and sanpham.idSP=hoadonnhaphang.IdSanPham and NHACUNGCAP.IdNCC= sanpham.IdNhaCungCap and size='" + size + "'; ";
                MessageBox.Show("th4");
            }

            data = DAO.ConnectDAO.getDataTable(sql);

            return data;
        }
    }
}
