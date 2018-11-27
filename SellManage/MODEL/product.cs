using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
  public  class product
    {
        #region propeties 

        private int id;
        private string name;
        private string supplier;
        private int size;
        private string color;
        private double outPrice;
        private string type;
        private string note;
        private string tag;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Supplies { get => supplier; set => supplier = value; }
        public int Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Type { get => type; set => type = value; }
        public string Note { get => note; set => note = value; }
        public string Tag { get => tag; set => tag = value; }
        public double OutPrice { get => outPrice; set => outPrice = value; }


        #endregion

        #region method 

        #endregion

    }
}
