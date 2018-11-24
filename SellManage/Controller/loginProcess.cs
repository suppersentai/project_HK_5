using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Controller
{
    public class loginProcess
    {
        public bool checkInvalid(String name, String password)
        {
            string regex = "\\w{6,30}";
            if (Regex.IsMatch(name, regex) && Regex.IsMatch(password, regex)) {
               return true;
           }
            return false;

        }
      
    }
}
