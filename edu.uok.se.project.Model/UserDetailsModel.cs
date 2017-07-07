using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police_Entry_Recording_System.edu.uok.se.project.Model
{
    class UserDetailsModel
    {
        private string userID;
        private string password;
        private string firstName;
        private string middleName;
        private string lastName;
        private string fullName;
        private string nic;
        private string mobileNo;
        private string contactNo;
        private string createdTime;
        private string updateTime;
        private string updateDate;

        public string UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public string Nic
        {
            get
            {
                return nic;
            }

            set
            {
                nic = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return mobileNo;
            }

            set
            {
                mobileNo = value;
            }
        }

        public string ContactNo
        {
            get
            {
                return contactNo;
            }

            set
            {
                contactNo = value;
            }
        }

        public string CreatedTime
        {
            get
            {
                return createdTime;
            }

            set
            {
                createdTime = value;
            }
        }

        public string UpdateTime
        {
            get
            {
                return updateTime;
            }

            set
            {
                updateTime = value;
            }
        }

        public string UpdateDate
        {
            get
            {
                return updateDate;
            }

            set
            {
                updateDate = value;
            }
        }
    }
}
