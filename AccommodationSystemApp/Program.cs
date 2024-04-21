using System;

namespace AccommodationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a person
            Person person = new Person("John", 30);

            // Creating a suite
            Suite suite = new Suite(101, 100); // Suite number and daily rate

            // Creating a reservation
            DateTime startDate = new DateTime(2024, 4, 21);
            DateTime endDate = new DateTime(2024, 5, 2);
            Reservation reservation = new Reservation(person, suite, startDate, endDate);

            // Displaying reservation information
            Console.WriteLine("Reservation for " + reservation.Guest.Name);
            Console.WriteLine("Suite: " + reservation.Suite.Number);
            Console.WriteLine("Check-in date: " + reservation.StartDate.ToShortDateString());
            Console.WriteLine("Check-out date: " + reservation.EndDate.ToShortDateString());
            Console.WriteLine("Number of days: " + reservation.CalculateNumberOfDays());
            Console.WriteLine("Total price of the reservation: " + reservation.CalculateTotalPrice().ToString("C2"));
        }
    }
}
