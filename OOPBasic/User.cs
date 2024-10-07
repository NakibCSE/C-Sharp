 using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; private set; }
        protected string id;
        public string ID
        { get { return id; } }

        public User(string userName, string password) {
            
            UserName = userName;
            Password = password;
        }
        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (Password == oldPassword) {
             Password = newPassword;
            }
        }
        public virtual void CreateID()
        {
            id = new IDGenerator().Generate();
        }
    }
}
