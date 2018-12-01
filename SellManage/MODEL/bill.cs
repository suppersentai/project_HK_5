using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class bill
    {
        int idBill;
        string idStaff;
        int idCustomer;
        DateTime dayOfSell;
        int totalMoney;
        List<detailBill> detail;

        public bill()
        {
           // detail.
        }
        public int IdBill { get => idBill; set => idBill = value; }
        public string IdStaff { get => idStaff; set => idStaff = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public DateTime DayOfSell { get => dayOfSell; set => dayOfSell = value; }
        public int TotalMoney { get => totalMoney; set => totalMoney = value; }
      
    }
}
