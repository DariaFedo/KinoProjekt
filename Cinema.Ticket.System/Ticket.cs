
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class Ticket
    {
        public Ticket(double price, string type)
        {
            try
            {
                counter++;
                this.Price = price;
                this.Type = type;
                this.IDticket = "Tic" + counter.ToString();
            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }

        public Ticket(Booking booking)
        {
            try
            {

            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }

        private static int counter=0;
        private double _Price;
        private string _Type;
        private string _IDticket;
        private Booking _Booking;


        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }

        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        public string IDticket
        {
            get
            {
                return _IDticket;
            }
            set
            {
                _IDticket = value;
            }
        }

        public Booking Booking
        {
            get
            {
                return _Booking;
            }
            set
            {
                _Booking = value;
            }
        }

        public void Edit()
        {
            throw new global::System.NotImplementedException();
        }

        public void Sellticket()
        {
            throw new global::System.NotImplementedException();
        }
    }
}