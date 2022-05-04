using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Calculator
{
    class Program
    {
        public static int Addition(int a, int b)
        {
            int sum;
            return  sum = a + b;
        }
        public static double Addition(double a, double b)
        {
            double sum = a + b;
            return sum ;
        }
        public static int Subtraction(int a, int b)
        {
            int difference = a - b;
            return difference ;
        }
        public static double Subtraction(double a, double b)
        {
            double difference = a - b;
            return difference;
        }
   
        public static int Multiplication(int a, int b)
        {
            int product = a * b;
            return product;

        }
        public static double Multiplication(double a, double b)
        {
            double product = a * b;
            return product;

        }
        public static int Division(int a, int b)
        {
            int quotient = a / b;
            return quotient;
        }
        public static double Division(double a, double b)
        {
            double quotient = a / b;
            return quotient;
        }
        static void Main(string[] args)
        {

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose Operator");
            string operators = Convert.ToString(Console.ReadLine());
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            

            if (operators == "+")
            {
                Console.WriteLine(Addition (x, y));
            }
            else if (operators == "-")
            {
                Console.WriteLine(Subtraction(x, y));
            }
            else if (operators == "*")
            {
                Console.WriteLine(Multiplication(x, y));
            }
            else if (operators == "/")
            {
                Console.WriteLine(Division(x, y));
            }


         


        }
    }
}
