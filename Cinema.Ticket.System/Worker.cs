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
        //public Worker()  ??? to po co? 

        //{
        //    try
        //    {
        //        counter++;
        //        this.Email = "blep";
        //        this.ID = "Wnr" + counter.ToString();
        //        this.Name = "blep";
        //        this.Phone = "blep";
        //        this.Surname = "blep";
        //        this.IdCard = "Work" + counter.ToString();
        //        this.Position = "blep";
        //        this.Login = "blep";
        //        this.Password = "blep";
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