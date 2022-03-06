using System;

namespace EmployWageComputation
{
    class Program
    {
        /// <summary>
        /// Calculate Part Time Employ wage
        /// </summary>
        static void Main(string[] args)
        {
            int dailyEmployWage;
            int isPartTimeEmployWage;

            int fullDayHours = 8;
            int isPartTimeHrs = 4;
            int empWagePerHour = 20;           
            
            Random random = new Random();
            int presenty = random.Next(3);

            if (presenty == 1)
            {
                Console.WriteLine("Employ is Present");
                dailyEmployWage = empWagePerHour * fullDayHours;
                Console.WriteLine("Employ Daily Wage is :{0} ", +dailyEmployWage);
            }
            else if (presenty == 0)
            {
                Console.WriteLine("Employ is Absent");
                Console.WriteLine("Employ per Day Wage is : 0");
            }
            else
            {
                isPartTimeEmployWage = empWagePerHour * isPartTimeHrs;
                Console.WriteLine("Part Time Employ Wage is : {0}", +isPartTimeEmployWage);
            }
            
            
        }
    }

}
