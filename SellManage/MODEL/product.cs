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
        private string size;
        private string leftOver;
        private string color;
        private string priceIn;
        private string priceOut;
        private string supply;
        private string note;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Size { get => size; set => size = value; }
        public string LeftOver { get => leftOver; set => leftOver = value; }
        public string Color { get => color; set => color = value; }
        public string PriceIn { get => priceIn; set => priceIn = value; }
        public string PriceOut { get => priceOut; set => priceOut = value; }
        public string Supply { get => supply; set => supply = value; }
        public string Note { get => note; set => note = value; }

        #endregion

        #region method 

        #endregion

    }
}
