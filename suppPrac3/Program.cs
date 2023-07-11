using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suppPrac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Decision;
            do
            {
                double WravMark = 0, WrscMark = 0;

                Console.Write("Do you have more data to process? (Y/N) ");
                Decision = char.Parse(Console.ReadLine());
              (WravMark,WrscMark)= GetoneStudent( WravMark,  WrscMark);
                canContinue(ref WravMark, ref WrscMark);
                DisplayDecision(ref WravMark, ref WrscMark);


            } while (Decision == 'Y' || Decision == 'y');
           

           
        }
        static (double,double) GetoneStudent(double WravMark,double  WrscMark)
        {

            do
            {
                Console.Write("Enter your WRAV101 mark(0-100) :");
                WravMark = double.Parse(Console.ReadLine());
            }
            while (WravMark < 0 || WravMark > 100);
            do
            {

                Console.Write("Enter your WRSC111 mark(0-100) :");
                WrscMark = double.Parse(Console.ReadLine());

            }
            while(WrscMark<0 || WrscMark > 100);
            
            return (WravMark,WrscMark);

        }
        static bool canContinue(ref double WravMark, ref double WrscMark)
        {
            return (WravMark >= 50 && WrscMark >= 50);
        }
        static void DisplayDecision(ref double WravMark,ref double WrscMark)
        {
            double average;
            
            char Decision;
            Console.Write("Do you have more data to process? (Y/N) ");
            Decision=char.Parse(Console.ReadLine());
           bool canContinueflag= canContinue( ref WravMark, ref WrscMark);
          
            average = (WravMark + WrscMark) / 2;
            Console.WriteLine("You average for the two  CS module is {0}", average);
            if (canContinueflag)
            {
                Console.WriteLine("You will be allowed to second semester modules");
            }
            else
            {
                Console.WriteLine("You will not be allowed to second semester modules");
            }
            
        }
        
    }
}
