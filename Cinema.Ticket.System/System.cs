using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Cinema.Ticket.System
{
    public class System
    {
        public System()
        {
            try
            {
                this.FilmCollection = new ObservableCollection<Film>();
                this.ClientCollection = new ObservableCollection<Client>();
                this.BookingCollection = new ObservableCollection<Booking>();
                this.RoomCollection = new ObservableCollection<Room>();
                this.ShowsCollection = new ObservableCollection<Show>();
                this.TicketCollection = new ObservableCollection<Ticket>();
                this.WorkerCollection = new ObservableCollection<Worker>();
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

        private ObservableCollection<Film> _FilmCollection;
        private ObservableCollection<Client> _ClientCollection;
        private ObservableCollection<Worker> _WorkerCollection;
        private ObservableCollection<Room> _RoomCollection;
        private ObservableCollection<Booking> _BookingCollection;
        private ObservableCollection<Show> _ShowsCollection;
        private ObservableCollection<Ticket> _TicketCollection;

        public ObservableCollection<Film> FilmCollection
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

        public ObservableCollection<Client> ClientCollection
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

        public ObservableCollection<Worker> WorkerCollection
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

        public ObservableCollection<Room> RoomCollection
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

        public ObservableCollection<Booking> BookingCollection
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

        public ObservableCollection<Show> ShowsCollection
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

        public ObservableCollection<Ticket> TicketCollection
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
                if (_WorkerCollection.Where(i => (i.Login == login) && (i.Password == password)) is null)
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