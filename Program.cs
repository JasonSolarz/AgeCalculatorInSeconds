using System;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables and declarations
            int userYear = 0;
            int userMonth = 0;
            int userDay = 0;
            double numSeconds;

            //Application header text and title
            Console.WriteLine("Calculate your age in seconds!\n------------------------------\n");
            Console.Title = "Age Calculator In Seconds";

            //Ask user for the year they were born.
            Console.Write("Please enter the year you were born: ");
            userYear = Convert.ToInt32(Console.ReadLine());

            //Ask user for the month they were born
            Console.Write("Please enter the month you were born(1 - 12): ");
            userMonth = Convert.ToInt32(Console.ReadLine());

            //Ask user for the day they were born
            Console.Write("please enter the day you were born(1 - 31): ");
            userDay = Convert.ToInt32(Console.ReadLine());

            //Create two time objects. One based of users DOB and one for todays date.
            DateTime DOB = new DateTime(userYear, userMonth, userDay);
            DateTime Today = DateTime.Now;

            //Calculate the difference between the users DOB and Today.
            numSeconds = (Today - DOB).TotalSeconds;

            //Output the time in seconds to the console
            Console.WriteLine($"You have been alive for {numSeconds :N0} seconds!");
        }
    }
}
