using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Double a, b, c, R;
                Console.Write("Enter a:");
                a = double.Parse(Console.ReadLine());
                Console.Write("Enter b:");
                b = double.Parse(Console.ReadLine());
                Console.Write("Enter c:");
                c = double.Parse(Console.ReadLine());

                R = (a + b + c)/3;
                
                {
                    Console.WriteLine( "R ="  + R);
                }
            }
            catch (Exception F)
            {
                Console.WriteLine(F.Message);




               

            
                
            }
        }
    }
}