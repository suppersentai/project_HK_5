using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class staff
    {
        int id;
        string name;
        string userName;
        string password;
        int checkAdmin;

        public int Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public int CheckAdmin { get => checkAdmin; set => checkAdmin = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
