using System;

namespace Deepening
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOperator = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (inputOperator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if(inputOperator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if(inputOperator == "%")
            {
                Console.WriteLine(number1 % number2);
            }

            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 20 && userInput % 3 == 0)
            {
                Console.WriteLine("20보다 큰 3의 배수입니다.");
            }
        }
    }
}
