using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class Booking
    {
        public Booking(Client client, double totalprice, DateTime dateofbook, Show show, int bookingstatus, ICollection<Ticket> ticketlist)
        {
            try
            {
                counter++;
                this.IDbooking = "Boooknr" + counter.ToString();
                this.Dateofbook = dateofbook;
                this.Clientsbookings = client;
                this.Show = show;
                this.BookingStatus = bookingstatus;
                this.TicketList = ticketlist;
                //this.TotalPrice = TotalPrice; zrobić liczenie na podstawie listy biletów;
            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }

        private static int counter = 0;
        private double _TotalPrice;
        private DateTime _Dateofbook;
        private string _IDbooking;
        private Client _Clientsbookings;
        private Show _Show;
        private int _BookingStatus;
        private ICollection<Ticket> _TicketList;


        public double TotalPrice
        {
            get
            {
                return _TotalPrice;
            }
            set
            {
                _TotalPrice = value;
            }
        }

        public DateTime Dateofbook
        {
            get
            {
                return _Dateofbook;
            }
            set
            {
                _Dateofbook = value;
            }
        }

        public string IDbooking
        {
            get
            {
                return _IDbooking;
            }
            set
            {
                _IDbooking = value;
            }
        }

        public Client Clientsbookings
        {
            get
            {
                return _Clientsbookings;
            }
            set
            {
                _Clientsbookings = value;
            }
        }

        public Show Show
        {
            get
            {
                return _Show;
            }
            set
            {
                _Show = value;
            }
        }

        public int BookingStatus
        {
            get
            {
                return _BookingStatus;
            }
            set
            {
                _BookingStatus = value;
            }
        }

        public ICollection<Ticket> TicketList
        {
            get
            {
                return _TicketList;
            }
            set
            {
                _TicketList = value;
            }
        }

        public void Cancelbooking()
        {
            throw new global::System.NotImplementedException();
        }
    }
}