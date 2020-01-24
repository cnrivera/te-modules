using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats 
        { 
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats {get; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats 
        {
            get 
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        public int TotalCoachSeats { get; }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats) 
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool enoughBooked = false;

            if (forFirstClass && AvailableFirstClassSeats >= totalNumberOfSeats)
            {
                BookedFirstClassSeats += totalNumberOfSeats;
                enoughBooked = true;
            }
            else if(!forFirstClass && AvailableCoachSeats >= totalNumberOfSeats)
            {
                BookedCoachSeats += totalNumberOfSeats;
                enoughBooked = true;
            }
            return enoughBooked;
        }
    }   
}

 
