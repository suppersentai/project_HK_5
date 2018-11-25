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
        private string type;
        private int size;
        private string color;
        private int outPrice;
        private string note;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Color { get => color; set => color = value; }
        public int Size { get => size; set => size = value; }
        public int OutPrice { get => outPrice; set => outPrice = value; }

        public string Note { get => note; set => note = value; }

        #endregion

        #region method 

        #endregion

    }
}
