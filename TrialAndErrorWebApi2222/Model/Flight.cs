using System;

namespace TrialAndErrorWebApi2222.Model
{
    public class Flight
    {
        
        public int FlightId { get; set; }
      
        public string FlightType { get; set; }
       
        public string FromLocation { get; set; }
     
        public string ToLocation { get; set; }
      
        public DateTime DepartTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public Flight(int _flightid, string _flighttype, string _fromlocation, string _tolocation, DateTime _departtime, DateTime _arrivaltime)
        {
            FlightId = _flightid;
            FlightType = _flighttype;
            FromLocation = _fromlocation;
            ToLocation = _tolocation;
            DepartTime = _departtime;
            ArrivalTime = _arrivaltime;
        }

        public Flight()
        {

        }
    }
}
