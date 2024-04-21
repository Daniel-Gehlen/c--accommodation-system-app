using System;

namespace AccommodationSystem
{
    public class Reservation
    {
        public Person Guest { get; set; }
        public Suite Suite { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Reservation(Person guest, Suite suite, DateTime startDate, DateTime endDate)
        {
            Guest = guest;
            Suite = suite;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int CalculateNumberOfDays()
        {
            return (EndDate - StartDate).Days;
        }

        public double CalculateTotalPrice()
        {
            int numberOfDays = CalculateNumberOfDays();
            double totalPrice = numberOfDays * Suite.DailyRate;

            if (numberOfDays > 10)
            {
                totalPrice *= 0.9; // Applying 10% discount for reservations longer than 10 days
            }

            return totalPrice;
        }
    }
}
