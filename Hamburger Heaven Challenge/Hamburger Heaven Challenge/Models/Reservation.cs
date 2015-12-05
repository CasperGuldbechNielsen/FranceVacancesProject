using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    public class Reservation
    {
        //fields
        private DateTime _arrival;
        private DateTime _departure;
        private TimeSpan _staying;


        //properties
        public DateTime Arrival
        {
            get { return _arrival; }
            set
            {
                // Throwing nice and fancy exceptions we can use in Unitesting
                _arrival = value;
            }
        }

        public DateTime Departure
        {
            get { return _departure; }
            set
            {
                // Throwing nice and fancy exceptions we can use in Unitesting
                _departure = value;
            }
        }

        public TimeSpan Staying
        {
            get { return _staying; }
            set
            {
                // Throwing nice and fancy exceptions we can use in Unitesting
                _staying = value;
            }
        }


        //Constructor
        public Reservation(DateTime arrival, DateTime departure, TimeSpan staying)
        {
            Arrival = arrival;
            Departure = departure;
            Staying = staying;
        }

       
    }
}
