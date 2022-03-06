using System;
namespace EmployWageComputation
{
    class Program
    {
        /// <summary>
        /// Using Switch case
        /// </summary>
        static void Main(string[] args)
        {
            int employWage =0;
            int presentHours =0;
            const int empWagePerHour = 20;           
            
            Random random = new Random();
            int presenty = random.Next(3);

            switch (presenty)
            {
                case 0:
                    Console.WriteLine("Employ is Full Time Present");
                    presentHours = 8;
                    break;
                case 1:
                    Console.WriteLine("Employ is Part Time Present");
                    presentHours = 4;
                    break;
                default:
                    Console.WriteLine("Employ is Absent");
                    presentHours = 0;
                    break;
            }
            employWage = empWagePerHour * presentHours;
            Console.WriteLine("Employ wage is : {0}",+ employWage);
        }        
    }
}
