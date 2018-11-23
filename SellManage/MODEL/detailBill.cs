using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    class detailBill
    {
        int idBill;
        int idProduct;
        int quantity;
        int price;

        public int IdBill { get => idBill; set => idBill = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
    }
}
