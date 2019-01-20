using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class Show
    {
        public Show(DateTime date, Film film, Room room)
        {
            try
            {
                counter++;
                this.IdShow = "Shownr" + counter.ToString();
                this.Date_of_show = date;
                this.Film = film;
                this.Cinema_rooms = room;
            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }
        public DateTime _Date_of_show;
        public Film _Film;
        public Room _Cinema_rooms;
        public string _IdShow;
        private static int counter = 0;



        public string IdShow
        {
            get
            {
                return _IdShow;
            }
            set
            {
                _IdShow = value;
            }
        }
        public DateTime Date_of_show
        {
            get
            {
                return _Date_of_show;
            }
            set
            {
                _Date_of_show = value;
            }
        }

        public Film Film
        {
            get
            {
                return _Film;
            }
            set
            {
                _Film = value;
            }
        }

        public Room Cinema_rooms
        {
            get
            {
                return _Cinema_rooms;
            }
            set
            {
                _Cinema_rooms = value;
            }
        }
    }
}