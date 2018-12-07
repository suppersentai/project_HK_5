using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace Controller.NhanVien
{
    public class accountProcess
    {
        public  void getAllStaff(DataGridView dgv)
        {
         DataTable data =  DAO.userDAO.getAllStaff();
            dgv.DataSource = data;
            dgv.Columns["idnv"].HeaderText = "Mã";
            dgv.Columns["tennv"].HeaderText = "Họ Tên";
            dgv.Columns["PhoneNV"].HeaderText = "Số điện thoại";
            dgv.Columns["NgaySinhNV"].HeaderText = "Ngày Sinh";
            dgv.Columns["DiaChiNV"].HeaderText = "Địa Chỉ";
            dgv.Columns["LuongNV"].HeaderText = "Lương";
            dgv.Columns["NgayVaoLam"].HeaderText = "ngày vào làm";
            dgv.Columns["GioiTinhNV"].HeaderText = "Giới Tính";

            //dgv.Columns["NgaySinhNV"].Visible = false;
            //dgv.Columns["DiaChiNV"].Visible = false;
            //dgv.Columns["NgayVaoLam"].Visible = false;
            dgv.Columns["idnv"].Width = 30;
            dgv.Columns["LuongNV"].DefaultCellStyle.Format = "# ###";
            dgv.Columns["LuongNV"].Width =60;
            dgv.Columns["GioiTinhNV"].Width = 30;
            dgv.Columns["tennv"].Width = 120;
            dgv.Columns["DiaChiNV"].Width = 150;
            dgv.Columns["NgayVaoLam"].Width = 70;
              dgv.Columns["NgaySinhNV"].Width = 70;
        }
    }
}
