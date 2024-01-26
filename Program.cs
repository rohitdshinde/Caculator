using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int result;


            Console.WriteLine("All method");
            Console.WriteLine("Enter a first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your choice a Adiition,b is substraction,Any key multiplication");
            answer=Console.ReadLine();
            if (answer =="a")
            {
                result = a + b;
            }
            else if (answer =="b")
            {
                result = a - b;

            }
            else
            {
                result = a * b;
            }

            Console.WriteLine("Your answer is" + result);



            Console.ReadKey();
        }
    }
}
