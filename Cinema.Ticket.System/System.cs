using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class System
    {
        public System()
        {
            try
            {
                this.FilmCollection = new List<Film>();
                this.ClientCollection = new List<Client>();
                this.BookingCollection = new List<Booking>();
                this.RoomCollection = new List<Room>();
                this.ShowsCollection = new List<Show>();
                this.TicketCollection = new List<Ticket>();
                this.WorkerCollection = new List<Worker>();
            }
            catch
            {
                throw new global::System.NotImplementedException();
            }

        }

        public System(System program)
        {
            try
            {
                this.FilmCollection = program.FilmCollection;
                this.ClientCollection = program.ClientCollection;
                this.BookingCollection = program.BookingCollection;
                this.RoomCollection = program.RoomCollection;
                this.ShowsCollection = program.ShowsCollection;
                this.TicketCollection = program.TicketCollection;
                this.WorkerCollection = program.WorkerCollection;
            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }

        private List<Film> _FilmCollection;
        private List<Client> _ClientCollection;
        private List<Worker> _WorkerCollection;
        private List<Room> _RoomCollection;
        private List<Booking> _BookingCollection;
        private List<Show> _ShowsCollection;
        private List<Ticket> _TicketCollection;

        public List<Film> FilmCollection
        {
            get
            {
                return _FilmCollection;
            }
            set
            {
                _FilmCollection = value;
            }
        }

        public List<Client> ClientCollection
        {
            get
            {
                return _ClientCollection;
            }
            set
            {
                _ClientCollection = value;
            }
        }

        public List<Worker> WorkerCollection
        {
            get
            {
                return _WorkerCollection;
            }
            set
            {
                _WorkerCollection = value;
            }
        }

        public List<Room> RoomCollection
        {
            get
            {
                return _RoomCollection;
            }
            set
            {
                _RoomCollection = value;
            }
        }

        public List<Booking> BookingCollection
        {
            get
            {
                return _BookingCollection;
            }
            set
            {
                _BookingCollection = value;
            }
        }

        public List<Show> ShowsCollection
        {
            get
            {
                return _ShowsCollection;
            }
            set
            {
                _ShowsCollection = value;
            }
        }

        public List<Ticket> TicketCollection
        {
            get
            {
                return _TicketCollection;
            }
            set
            {
                _TicketCollection = value;
            }
        }

        public Ticket Ticket
        {
            get
            {
                return Ticket;
            }
            set
            {

            }
        }

        public Film Film
        {
            get
            {
                return Film;
            }
            set
            {
            }
        }

        public Worker Worker
        {
            get
            {
                return Worker;
            }
            set
            {

            }
        }

        public Client Client
        {
            get
            {
                return Client;
            }
            set
            {
            }
        }

        public Room Cinema_rooms
        {
            get
            {
                return Cinema_rooms;
            }
            set
            {
            }
        }

        public Booking Booking
        {
            get
            {
                return Booking;
            }
            set
            {
            }
        }

        public bool Log(string login, string password)
        {
            try
            {
                if (_WorkerCollection.Find(i => (i.Login == login) && (i.Password == password)) is null)
                    return false;
                else
                {
                    return true;
                }

            }
            catch
            {
                throw new Exception("Log in problem");
            }

        }

        public void Search()
        {
            //  throw new System.NotImplementedException();
        }

        public void Edit()
        {
            //  throw new System.NotImplementedException();
        }
    }
}