using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    class Reservation
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
    }
}
