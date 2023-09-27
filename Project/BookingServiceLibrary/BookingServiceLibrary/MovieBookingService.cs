using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookingServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MovieBookingService" in both code and config file together.
    public class MovieBookingService : IMovieBookingService
    {
        public List<MovieScreening> Screenings = new List<MovieScreening>();
        public void AddMovieScreening(MovieScreening thisScreening)
        {
            Screenings.Add(thisScreening);
        }

        public List<MovieScreening> GetAllScreenings()
        {
            return Screenings;
        }

        public void AddBookingToScreening(string moiveTitle, Booking booking)
        {
            var bookings = GetAllBookingsForScreening(moiveTitle);
            bookings.Add(booking);
        }
        public List<Booking> GetAllBookingsForScreening(string movieTitle)
        {
            var screenings = Screenings.FirstOrDefault(i => i.MovieTitle == movieTitle);
            if (screenings.Bookings == null)
            {
                screenings.Bookings = new List<Booking>();
            }
            return screenings.Bookings;

        }
    }
}
