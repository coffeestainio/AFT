using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private string _username;
        private string _password;

        public User(string username,string password)
        {
            _username = username;
            _password = password;
        }

        public string username { get
            { return _username; }
        }

        public string password
        {
            get
            { return _password; }
        }

    }
}
