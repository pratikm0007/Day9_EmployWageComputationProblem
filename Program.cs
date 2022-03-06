using System;
namespace EmployWageComputation
{
    class Program
    {
        /// <summary>
        /// Monthly wage
        /// </summary>
        static void Main(string[] args)
        {
            int employWage = 0;
            int presentHours = 0;
            int monthlyEmpWage = 0;
            const int empWagePerHour = 20;
            const int dayInMonth = 20;

            for (int i = 0; i < dayInMonth; i++)
            {
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
                monthlyEmpWage += employWage;
                Console.WriteLine("Employ wage is : {0}", + employWage);
            }
            Console.WriteLine("Monthly Employ wage is :{0}",+ monthlyEmpWage);
            
        }        
    }
}
