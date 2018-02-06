using System;
using System.Collections.Generic;
using System.Linq;

namespace TrialAndErrorWebApi2222.Model
{
    public class Repo
    {
        public static List<Flight> listOfFlights = new List<Flight>();
        public static object mylock = new object();

        public static void PopulateList()
        {
            Flight A = new Flight
            {
                FlightId = 1,
                FlightType = "AC130",
                FromLocation = "Copenhagen",
                ToLocation = "Berlin",
                DepartTime = DateTime.Parse("2018-05-01"),
                ArrivalTime = DateTime.Parse("2018-08-01")
            };
            Flight B = new Flight
            {
                FlightId = 2,
                FlightType = "AC130",
                FromLocation = "Berlin",
                ToLocation = "Copenhagen",
                DepartTime = DateTime.Parse("2018-11-02"),
                ArrivalTime = DateTime.Parse("2018-12-02")
            };
            Flight C = new Flight
            {
                FlightId = 3,
                FlightType = "AC130",
                FromLocation = "Copenhagen",
                ToLocation = "Madrid",
                DepartTime = DateTime.Parse("2018-05-03"),
                ArrivalTime = DateTime.Parse("2018-08-03")
            };
            listOfFlights.Add(A);
            listOfFlights.Add(B);
            listOfFlights.Add(C);
        }

        public static Flight GetById(int id)
        {
            return listOfFlights.Find(product => product.FlightId == id);
        }

        public static List<Flight> GetAllFlights()
        {
            PopulateList();
            return listOfFlights.ToList();
        }

        public static string ChangeFlight(int _flightNumber, string fromLocation, string toLocation)
        {
            string message = "";
            Flight flight = GetById(_flightNumber);
            lock (mylock)
            {
                if (flight != null)
                {
                    flight.FromLocation = fromLocation;
                    flight.ToLocation = toLocation;
                    message = "Your flight has been changed";
                }
                else
                {
                    message = "The flight has not found";
                }
            }
            return message;
        }
    }
}
