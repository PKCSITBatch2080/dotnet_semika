using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter your date of birth (YYYY/MM/DD):");
            string dobString = Console.ReadLine();

            DateTime dob;
            if (!DateTime.TryParse(dobString, out dob))
            {
                Console.WriteLine("Invalid date format. Please enter date in YYYY/MM/DD format.");
                return;
            }
            string cFullName = fullName.ToUpper();

            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Hello, {cFullName} Ji!");
            Console.WriteLine($"Your DOB: {dob.ToString("dddd, dd MMMM yyyy")}");
            DateTime now = DateTime.Now;
            int years = now.Year - dob.Year;
            int months = now.Month - dob.Month;
            int days = now.Day - dob.Day;
            if (months < 0 || (months == 0 && days < 0))
            {
                years--;
                months += (months < 0) ? 12 : 0;
                days += (days < 0) ? DateTime.DaysInMonth(now.Year, now.Month) : 0;
            }
            Console.WriteLine($"Age as of now: {years} Years {months} Months {days} Days");
        }
    }
}

