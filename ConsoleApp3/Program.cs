using System;
using AssignmentLibrary;

namespace ConsoleApp3
{
    class Program
    {   
       

        static void Main(string[] args)
        {
            DateTime fromdate = TimeAndDate.FromDate();
            Console.WriteLine(fromdate);
            Console.WriteLine("----------------------------");
            DateTime todate =TimeAndDate.ToDate();
            Console.WriteLine(todate);
          
            if (fromdate< DateTime.Now)
            {
                if (todate>= fromdate)
                {
                   TimeAndDate.Calculation( todate, fromdate);
                }
                else
                {
                    todate=TimeAndDate.ToDate();
                    Console.WriteLine(todate);
                    TimeAndDate.Calculation( todate, fromdate);
                }
            }
            else
            {
                Console.Write("FromDate is greater than today'date .Try Again");
            }
            }
        }
    }
