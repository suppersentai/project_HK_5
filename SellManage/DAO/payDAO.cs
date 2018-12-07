using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
namespace DAO
{
    public class payDAO
    {
        public static bool payAndInsertBill(bill bil)
        {
          
            string sql = "insert into HOADON values('" + bil.IdBill + "',N'" + bil.IdStaff + "','" + CONST.customer.Id + "','" + bil.DayOfSell.ToString("yyyy/MM/dd") + "','" + bil.TotalMoney + "')";
            if (ConnectDAO.queryNonQuery(sql))
                return true;
              
            //Console.WriteLine("HOA DON");
            //Console.WriteLine(" ma HOA DON" + bil.IdBill);
            //Console.WriteLine("id nhan vien" + bil.IdStaff);
            //Console.WriteLine("id n kHach" + CONST.customer.Id);
            //Console.WriteLine("Ngay ban" + bil.DayOfSell);
            //Console.WriteLine("tong tien" + bil.TotalMoney); 
            return false;
        }
        public static bool payAndInsertDetailBill(DataGridView dgv, bill bil)
        {
            MessageBox.Show("Toan 3");
            bool check = false; ;
            int i = 0;
            for (i = 0; i < dgv.Rows.Count; i++)
            {
                check = false;
                detailBill detaiBill = new detailBill();
                detaiBill.IdBill = bil.IdBill;
                detaiBill.IdProduct = int.Parse(dgv.Rows[i].Cells["idsp"].Value.ToString());
                detaiBill.Price = int.Parse(dgv.Rows[i].Cells["giaban"].Value.ToString());
                detaiBill.Quantity = int.Parse(dgv.Rows[i].Cells["soluong"].Value.ToString());

                string sql = "insert into CHITIETHOADON values('" + detaiBill.IdBill + "','" + detaiBill.IdProduct + "','" + detaiBill.Price + "','" + detaiBill.Quantity + "')";
                if (ConnectDAO.queryNonQuery(sql))
                    check = true;
                if (!check)
                {
                    break;
                }


                //Console.WriteLine("chi tuet HOA DON");
                //Console.WriteLine(" ma ct HOA DON" + detaiBill.IdBill);
                //Console.WriteLine(" id san pham" + detaiBill.IdProduct);
                //Console.WriteLine("gia" + detaiBill.Price);
                //Console.WriteLine("sol luong" + detaiBill.Quantity);
            }
           
            return check;
        }
        public static bool insertCustomerDAO(customer cus)
        {
            Console.WriteLine(cus.Name);
            Console.WriteLine(cus.Address );
            Console.WriteLine(cus.Phone);
            Console.WriteLine(cus.Gender);
            string sql = "insert into khachhang values('',N'" + cus.Name + "',N'" + cus.Address + "',N'" + cus.Phone + "',N'" + cus.Gender + "')";
            if (ConnectDAO.queryNonQuery(sql))
                return true;
            return false;
        }
    }
}
