using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Ticket.System
{
    public class Room
    {
        public Room(char row, int roomnumber, int seatnumber)
        {
            try
            {
                this.Roomid = "Room" + counter.ToString();
                this.Room_number = roomnumber;
                this.Row = row;
                this.SeatNumber = seatnumber;
            }
            catch
            {
                throw new global::System.NotImplementedException();
            } 
        }
        private static int counter = 0;
        private char _Row;
        private string _Roomid;
        private int _Room_number;
        private int _SeatNumber;

        public char Row
        {
            get
            {
                return _Row;
            }
            set
            {
                _Row = value;
            }
        }

        public string Roomid
        {
            get
            {
                return _Roomid;
            }
            set
            {
                _Roomid = value;
            }
        }

        public int Room_number
        {
            get
            {
                return _Room_number;
            }
            set
            {
                _Room_number = value;
            }
        }

        public int SeatNumber
        {
            get
            {
                return _SeatNumber;
            }
            set
            {
                _SeatNumber = value;
            }
        }
    }
}