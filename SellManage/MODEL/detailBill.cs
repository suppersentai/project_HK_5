using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class detailBill
    {
        int idBill;
        int idProduct;
        String nameProduct;
        int quantity;
        int price;
        bill bills;
        public detailBill()
        {
            this.idBill = bills.IdBill;

        }
     
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
    }
}
