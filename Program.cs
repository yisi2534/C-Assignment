using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num = 0;
            Console.WriteLine("Enter the number of students: ");
            num = int.Parse(Console.ReadLine());
            while (i < num)
            {
                Console.WriteLine("Enter mark ");
                double mark = double.Parse(Console.ReadLine());
                if (mark < 100 && mark > 90)
                {
                    Console.WriteLine("A");
                    Console.ReadLine();
                }
                else if (mark < 90 && mark > 80)
                {
                    Console.WriteLine("B");
                    Console.ReadLine();
                }
                else if (mark < 80 && mark > 70)
                {
                    Console.WriteLine("C");
                    Console.ReadLine();
                }
                else if (mark < 70 && mark > 60)
                {
                    Console.WriteLine("D");
                    Console.ReadLine();
                }
                else if (mark < 60 && mark > 0)
                {
                    Console.WriteLine("F");
                    Console.ReadLine();
                }
                else
                    Console.WriteLine("incorrect entry");
                i++;
            }
        }
    }
}
