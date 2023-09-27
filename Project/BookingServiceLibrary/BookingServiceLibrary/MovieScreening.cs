using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BookingServiceLibrary
{
    [DataContract]
    public class MovieScreening
    {
        [DataMember]
        public string MovieTitle;
        [DataMember]
        public DateTime DateCreated;
        [DataMember]
        public int NumberOfSeats;
        [DataMember]
        public string Ratings;
        [DataMember]
        public List<Booking> Bookings;
    }
}
