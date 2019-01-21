using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class Worker : Person
    {
        public Worker(string email, string name, string phone, string surname, string postion, string login, string password)
        {
            try
            {
                counter++;
                this.Email = email;
                this.ID = "Wnr" + counter.ToString();
                this.Name = name;
                this.Phone = phone;
                this.Surname = surname;
                this.IdCard = "Work" + counter.ToString();
                this.Position = postion;
                this.Login = login;
                this.Password = password;

            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }

        //public Worker(Worker worker1)
        //{
        //    try
        //    {
                
        //        this.Email = worker1.Email;
        //        this.ID = worker1.ID;
        //        this.Name = worker1.Name;
        //        this.Phone = worker1.Phone;
        //        this.Surname = worker1.Surname;
        //        this.IdCard = worker1.IdCard;
        //        this.Position = worker1.Postion;
        //        this.Login = worker1.Login;
        //        this.Password = worker1.Password;

        //    }
        //    catch
        //    {
        //        throw new global::System.NotImplementedException();
        //    }
        //}

        //public Worker()
        //{
        //    try
        //    {
        //    }
        //    catch
        //    {
        //        throw new global::System.NotImplementedException();
        //    }
        //}
        private static int counter = 0;
        private string _IdCard;
        private string _Position;
        private string _Login;
        private string _Password;

        public string IdCard
        {
            get
            {
                return _IdCard;
            }
            set
            {
                _IdCard = value;
            }
        }

        public string Position
        {
            get
            {
                return _Position;
            }
            set
            {
                _Position = value;
            }
        }

        public string Login
        {
            get
            {
                return _Login;
            }
            set
            {
                _Login = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

    }
}