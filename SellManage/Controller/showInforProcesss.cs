using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MODEL;
namespace Controller
{
    public class showInforProcesss
    {
  
        public static void showTypeOnCombox( ComboBox cbType)
        {
            //show combobox type

            List < typeProduct > list = DAO.showInforDAO.takeListType();
             cbType.DataSource = list;
            cbType.DisplayMember = "name";
            cbType.ValueMember = "id";
        }

        public static void showSizeOnCombox(ComboBox cbsize)
        {
      

            HashSet<int> list = DAO.showInforDAO.takeListSize();// Hashset de bo du lieu trung  
            List<int> list2 = list.ToList();// sau do convert hastset sang List vi dataSource  khong nhan Hashset
            cbsize.DataSource = list2;
            cbsize.DisplayMember = "size";

        }
        public static void showColorOnCombox(ComboBox cbsize)
        {
           


            HashSet<String> list = DAO.showInforDAO.takeListColor();// Hashset de bo du lieu trung  
            List<String> list2 = list.ToList();// sau do convert hastset sang List vi dataSource  khong nhan Hashset
            cbsize.DataSource = list2;
            cbsize.DisplayMember = "color";

            cbsize.ValueMember = "color";

        }

        public static void showOnPriceCombox(ComboBox cbPrice)
        {
            //show combobox price


            List<typeProduct> list = DAO.showInforDAO.takeListType();
            cbPrice.DataSource = list;
            cbPrice.DisplayMember = "name";
            cbPrice.ValueMember = "id";
        }
        public static List<product> getListProductProsess ()
        {
            return DAO.showInforDAO.getListProduct();

        }
    }
}
