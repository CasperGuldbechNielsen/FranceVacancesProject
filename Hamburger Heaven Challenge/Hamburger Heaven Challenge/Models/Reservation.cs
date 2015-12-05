using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    public class Reservation
    {
       
        private DateTime _arrival;
        private DateTime _departure;
        private TimeSpan _staying;

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

        public Reservation(DateTime _arrival, DateTime _departure, TimeSpan _staying)
        {
            Arrival = _arrival;
            Departure = _departure;
            Staying = _staying;
        }
    }
}
