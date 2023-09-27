using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using BookingServiceLibrary;

namespace BookingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/BookingServiceLibrary");
            ServiceHost selfHost = new ServiceHost(typeof(MovieBookingService), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IMovieBookingService), new WSHttpBinding(), "BookingServiceLibrary.MovieBookingService");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("THe service is ready");
                Console.WriteLine("Press enter to terminate the service");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occureed: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
