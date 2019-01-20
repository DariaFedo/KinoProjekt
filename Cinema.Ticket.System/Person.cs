using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public abstract class Person
    {
        private string _Name;
        private string _Surname;
        private string _ID;
        private string _Phone;
        private string _Email;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                _Surname = value;
            }
        }

        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
    }
}