using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MODEL;
using System.Data;
namespace Controller
{
    public class showInforProcesss
    {
        #region Hiển thị thông tin và chưc năng lọc trong  combobox
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


            List<product> list = DAO.showInforDAO.takeListSize();// Hashset de bo du lieu trung  
            List<product> list2 = new List<product>() ;// = list.ToList();// sau do convert hastset sang List vi dataSource  khong nhan Hashset
            list2.Add(list[0]);
            foreach (product item in list)
            {
                bool check = false;
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list2[i].Size == item.Size)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    list2.Add(item);
                }
            }
            cbsize.DataSource = list2;
            cbsize.DisplayMember = "size";
            cbsize.ValueMember = "size";
           // MessageBox.Show("Trđue");


        }
        public static void showColorOnCombox(ComboBox cbsize)
        {
            List<product> list = DAO.showInforDAO.takeListColor();// Hashset de bo du lieu trung  
            List<product> list2 = new List<product>();// = list.ToList();// sau do convert hastset sang List vi dataSource  khong nhan Hashset
            list2.Add(list[0]);

            foreach (product item in list)
            {
                bool check = false;
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list2[i].Color == item.Color)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    list2.Add(item);
                }
            }
            cbsize.DataSource = list2;
            cbsize.DisplayMember = "color";
            cbsize.ValueMember = "color";

        }

        public static void showOnPriceCombox(ComboBox cbPrice)
        {
            //show combobox price
        }
        public static void filterComboxValues(ComboBox type,ComboBox size, ComboBox color)
        {
            //lọc giá giá trị khi thay đổi selectedIndex
            String typeValue = type.SelectedValue.ToString();
            String sizeValue = size.SelectedValue.ToString();
            String colorValue = color.SelectedValue.ToString();
            DataTable dataView = DAO.showInforDAO.filterCombox(typeValue,sizeValue,colorValue);

        }
        public static List<product> getListProductProsess ()
        {
            return DAO.showInforDAO.getListProduct();

        }
        #endregion
    }
}
