using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace BookingServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovieBookingService" in both code and config file together.
    [ServiceContract]
    public interface IMovieBookingService
    {
        [OperationContract]
        List<Booking> GetAllBookingsForScreening(string movieTitle);
        [OperationContract]
        void AddBookingToScreening(string movieTitle, Booking booking);
        [OperationContract]
        void AddMovieScreening(MovieScreening thisScreening);
        [OperationContract]
        List<MovieScreening> GetAllScreenings();
    }
}
