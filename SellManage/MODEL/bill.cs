using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class bill
    {
        int id;
        string idStaff;
        DateTime dayOfSell;
        int totalMoney;

        public int Id { get => id; set => id = value; }
        public string IdStaff { get => idStaff; set => idStaff = value; }
        public DateTime DayOfSell { get => dayOfSell; set => dayOfSell = value; }
        public int TotalMoney { get => totalMoney; set => totalMoney = value; }
    }
}
