using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first_num, second_num, calc_num;

            Console.Write("First Number: ");
            first_num = double.Parse(Console.ReadLine());

            Console.Write("Second Number: ");
            second_num = double.Parse(Console.ReadLine());

            calc_num = first_num + second_num;

            if (calc_num < 10)
            {
                Console.Clear();
                Console.WriteLine("First: "+first_num);
                Console.WriteLine("Second: "+second_num);
                Console.WriteLine(calc_num + " is less than 10.");
            }            
            else if (calc_num == 10)
            {
                Console.Clear();
                Console.WriteLine("First: "+first_num);
                Console.WriteLine("Second: "+second_num);
                Console.WriteLine(calc_num+" is equal to 10.");
            }
            else if (calc_num > 10)
            {
                Console.Clear();
                Console.WriteLine("First: " + first_num);
                Console.WriteLine("Second: " + second_num);
                Console.WriteLine(calc_num+ " is greater than 10.");
            }
            Console.ReadKey();


        }
    }
}
