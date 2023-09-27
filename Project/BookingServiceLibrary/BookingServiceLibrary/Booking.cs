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
    public class Booking
    {
        [DataMember]
        public string BookedBy;
        [DataMember]
        public DateTime DateBooked;
        [DataMember]
        public int NumberOfTickets;
        [DataMember]
        public string BookingID;
    }
}
