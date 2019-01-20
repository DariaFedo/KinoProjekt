using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class Film
    {

        public Film(int agerestriction, string cast, string director, string genre, string language, float length, DateTime premiere, string techversion, string title)
        {
            try
            {
                counter++;
                this.IDfilm = "Mov" + counter.ToString();
                this.AgeRestriction = agerestriction;
                this.Cast = cast;
                this.Director = director;
                this.Genre = genre;
                this.Language = language;
                this.Length = length;
                this.Premiere = premiere;
                this.Title = title;
                this.TechVersion = techversion;
                
            }
            catch
            {
                throw new global::System.NotImplementedException();
            }
        }

        private static int counter = 0;
        private float _Length;
        private DateTime _Premiere;
        private string _Genre;
        private string _Cast;
        private int _AgeRestriction;
        private string _Director;
        private string _Title;
        private string _Language;
        private string _TechVersion;
        private string _IDfilm;

        public float Length
        {
            get
            {
                return _Length;
            }
            set
            {
            }
        }

        public DateTime Premiere
        {
            get
            {
                return _Premiere;
            }
            set
            {
                _Premiere = value;
            }
        }

        public string Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                _Genre = value;
            }
        }

        public string Cast
        {
            get
            {
                return _Cast;
            }
            set
            {
                _Cast = value;
            }
        }

        public int AgeRestriction
        {
            get
            {
                return _AgeRestriction;
            }
            set
            {
                _AgeRestriction = value;
            }
        }

        public string Director
        {
            get
            {
                return _Director;
            }
            set
            {
                _Director = value;
            }
        }

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }

        public string Language
        {
            get
            {
                return _Language;
            }
            set
            {
                _Language = value;
            }
        }

        public string TechVersion
        {
            get
            {
                return _TechVersion;
            }
            set
            {
                _TechVersion = value;
            }
        }

        public string IDfilm
        {
            get
            {
                return _IDfilm;
            }
            set
            {
                _IDfilm = value;
            }
        }
    }
}