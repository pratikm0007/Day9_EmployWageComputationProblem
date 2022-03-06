using System;

namespace EmployWageComputation
{
    class Program
    {
        /// <summary>
        /// Check employs are absent or present.
        /// </summary>
        static void Main(string[] args)
        {

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
        }
    }
}
