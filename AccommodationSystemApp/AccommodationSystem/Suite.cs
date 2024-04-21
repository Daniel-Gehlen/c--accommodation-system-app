using System;

namespace AccommodationSystem
{
    public class Suite
    {
        public int Number { get; set; }
        public double DailyRate { get; set; }

        public Suite(int number, double dailyRate)
        {
            Number = number;
            DailyRate = dailyRate;
        }
    }
}
