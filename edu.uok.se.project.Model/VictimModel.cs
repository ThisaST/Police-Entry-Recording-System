using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police_Entry_Recording_System.edu.uok.se.project.Model
{
    class VictimModel
    {
        private int victim_ID;
        private string nameWithInitials;
        private string fullName;
        private string nic;
        private string dateOfBirth;
        private string gender;
        private string permenentAddNno;
        private string permenentAddStreet;
        private string permenentAddCity;
        private string temporaryAddNo;
        private string temporaryAddStreet;
        private string temporaryAddCity;
        private string occupation;
        private int mobileNo;
        private int contactNo;
        private string emailAddress;
        private string status;
        private string religion;
        private string nationality;

        public int Victim_ID
        {
            get
            {
                return victim_ID;
            }

            set
            {
                victim_ID = value;
            }
        }

        public string NameWithInitials
        {
            get
            {
                return nameWithInitials;
            }

            set
            {
                nameWithInitials = value;
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

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string PermenentAddNno
        {
            get
            {
                return permenentAddNno;
            }

            set
            {
                permenentAddNno = value;
            }
        }

        public string PermenentAddStreet
        {
            get
            {
                return permenentAddStreet;
            }

            set
            {
                permenentAddStreet = value;
            }
        }

        public string PermenentAddCity
        {
            get
            {
                return permenentAddCity;
            }

            set
            {
                permenentAddCity = value;
            }
        }

        public string TemporaryAddNo
        {
            get
            {
                return temporaryAddNo;
            }

            set
            {
                temporaryAddNo = value;
            }
        }

        public string TemporaryAddStreet
        {
            get
            {
                return temporaryAddStreet;
            }

            set
            {
                temporaryAddStreet = value;
            }
        }

        public string TemporaryAddCity
        {
            get
            {
                return temporaryAddCity;
            }

            set
            {
                temporaryAddCity = value;
            }
        }

        public string Occupation
        {
            get
            {
                return occupation;
            }

            set
            {
                occupation = value;
            }
        }

        public int MobileNo
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

        public int ContactNo
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

        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Religion
        {
            get
            {
                return religion;
            }

            set
            {
                religion = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }
    }
}
