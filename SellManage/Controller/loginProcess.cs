﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Controller
{
    public class loginProcess
    {
        public  bool checkInvalid(String name, String password)
        {
            string regex = "\\w{6,30}";
            Regex.IsMatch(name, regex);
            if (Regex.IsMatch(name, regex) || Regex.IsMatch(password, regex)) {
                return true;
            }
            return false;
        }
        public bool checkExistAccount(String name, String password)
        {
            if (DAO.userDAO.checkExistAccount(name,password))
                return true;
            return false;
        }
    }
}