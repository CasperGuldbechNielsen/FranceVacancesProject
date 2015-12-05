using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    public class ReservationManager
    {
        public Reservation MakeReservation(DateTime arrivalDate, DateTime departureDate, TimeSpan lenghtStaying )
        {
            Reservation newReservation = new Reservation(arrivalDate, arrivalDate, lenghtStaying);
            newReservation.Arrival = arrivalDate;
            newReservation.Departure = departureDate;
            newReservation.Staying = lenghtStaying;
            return newReservation;
        }


        public static List<Reservation> getBookings()
        {
            var bookings = new List<Reservation>();

            bookings.Add(new Reservation(DateTime.FromFileTime(Calendar.CurrentEra),DateTime.FromFileTime(Calendar.CurrentEra), TimeSpan.FromDays(Double.Epsilon)));

            return bookings;
        }



        //Some methods

        public string BookAnApartment()
        {
            return "You have booked";
        }

        public string CancelBooking()
        {
            return "You have succesfuly canceled your booking";
        }


    }
}
