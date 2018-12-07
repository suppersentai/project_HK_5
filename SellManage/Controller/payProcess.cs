using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using System.Data;
namespace Controller
{
   public  class payProcess
    {
       
    public static void createBill(DataGridView dgvBil,bill bil)
        {
          
            if(DAO.payDAO.payAndInsertBill(bil))
                if (DAO.payDAO.payAndInsertDetailBill(dgvBil, bil))
                {
                    MessageBox.Show("ok");
                }

        }
        public  static void getCustomerIfExist(string phoneCustomer)
        {
          
            string sql = "select * from khachhang where phonekh='" + phoneCustomer + "'";
            DataTable data = DAO.ConnectDAO.getDataTable(sql); 
            if (data.Rows.Count >= 1)
            {
                CONST.customer = new customer();
                MessageBox.Show(data.Rows[0]["idkh"].ToString());
                CONST.customer.Id = int.Parse(data.Rows[0]["idkh"].ToString());
                CONST.customer.Name= data.Rows[0]["TenKH"].ToString();
                CONST.customer.Address= data.Rows[0]["DiaChiKH"].ToString();
                CONST.customer.Phone= data.Rows[0]["PhoneKH"].ToString();
                CONST.customer.Gender= data.Rows[0]["GioiTinhKH"].ToString();
            }
            else
            {
                CONST.customer = null;
            }
          
        }
        public static  void insertNewCustomer( customer cus)
        {
         
            DAO.payDAO.insertCustomerDAO(cus);
        }
    }
}
