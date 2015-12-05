using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    public static class ReservationManager
    {
        public static void MakeReservation(DateTime arrivalDate, DateTime departureDate, TimeSpan lenghtStaying )
        {
            // bool isAvailable
            //break;
        }


        public static List<Reservation> getBookings()
        {
            var bookings = new List<Reservation>();

            bookings.Add(new Reservation(DateTime.FromFileTime(Calendar.CurrentEra),DateTime.FromFileTime(Calendar.CurrentEra), TimeSpan.FromDays(Double.Epsilon)));

            return bookings;
        }
    }
}
