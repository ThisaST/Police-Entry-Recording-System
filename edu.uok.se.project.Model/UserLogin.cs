using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police_Entry_Recording_System
{
    class UserLogin
    {
        private string UserID;
        private string Password;

        public string Password1
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }

        public string UserID1
        {
            get
            {
                return UserID;
            }

            set
            {
                UserID = value;
            }
        }
    }
}
