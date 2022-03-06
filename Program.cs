﻿using System;

namespace EmployWageComputation
{
    class Program
    {
        /// <summary>
        /// The daily employ wage
        /// </summary>
        static void Main(string[] args)
        {
            int dailyEmployWage;
            int fullDayHours = 8;
            int empWagePerHour = 20;
            Random random = new Random();
            int presenty = random.Next(2);

            if (presenty == 1)
            {
                Console.WriteLine("Employ is Present");

            }
            else if (presenty == 0)
            {
                Console.WriteLine("Employ is Absent");
                Console.WriteLine("Employ per Day Wage is : 0");
            }
            dailyEmployWage = empWagePerHour * fullDayHours;
            Console.WriteLine("Employ Daily Wage is :{0} ", +dailyEmployWage);
        }
    }
    
}
