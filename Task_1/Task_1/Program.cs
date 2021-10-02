using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------- Task 1 -------------------------------");

            int a, b;
            string action;

            Console.Write(" Enter number a : ");
            a = int.Parse(Console.ReadLine());

            Console.Write(" Enter number b : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(" Select an action : '+', '-','*','/'");
            action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine(" Result = " + (a + b));
            }
            else if (action == "-")
            {
                Console.WriteLine(" Result = " + (a - b));
            }
            else if (action == "*")
            {
                Console.WriteLine(" Result = " + a * b);
            }
            else if (action == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine(" Error !!");
                }
                else
                {
                    Console.WriteLine(" Result = " + a / b);
                }
            }

            Console.WriteLine("------------------------------- Task 2 -------------------------------");

            string answer;

            Console.WriteLine(" How are you ? ");
            answer = Console.ReadLine();

            Console.WriteLine(" You are " + answer + ".");

            Console.WriteLine("------------------------------- Task 3 -------------------------------");

            char first, second, third;

            Console.Write(" Enter first char : ");
            first = char.Parse(Console.ReadLine());

            Console.Write(" Enter second char : ");
            second = char.Parse(Console.ReadLine());

            Console.Write(" Enter third char : ");
            third = char.Parse(Console.ReadLine());

            Console.WriteLine(" You enter (" + first + "), (" + second + "), (" + third + ").");

            Console.WriteLine("------------------------------- Task 4 -------------------------------");

            int firstNumber = 0;
            int secondNumber = 0;
            bool result;

            Console.Write(" Enter first number : ");
            firstNumber = int.Parse(Console.ReadLine());
            
            Console.Write(" Enter second number : ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber >0 && secondNumber >0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            if (result)
            {
                Console.WriteLine(" Numbers are positive. ");
            }
            else
            {
                if (firstNumber <= 0 || secondNumber <= 0)
                {
                    Console.WriteLine(" One of numbers is not positive. ");
                }
                else
                {
                    Console.WriteLine(" Both numbers are not positive. ");
                }
            }
            Console.ReadKey();
        }
    }
}
