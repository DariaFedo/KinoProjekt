using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class Client : Person
    {
        public Client(string email, string name, string phone, string surname)
        {
            try
            {
                counter++;
                this.ID = "Cnr" + counter.ToString();
                this.Name = name;
                this.Surname = surname;
                this.Phone = phone;
                this.Email = email;
            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }
        private static int counter = 0;
        private string _ID;
        private string _Name;
        private string _Surname;
        private string _Email;
         

    }
}