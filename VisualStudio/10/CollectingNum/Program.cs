using System;

namespace CollectingNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자맞추기 게임");

            Random random = new Random();
            int defender = random.Next(1, 101);
            Console.WriteLine(defender);

            int index = 0;
            while(index < 6)
            {

                Console.WriteLine("숫자를 입력하세요");
                int attack = int.Parse(Console.ReadLine());

                if (defender < attack)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                    index++;
                    continue;
                }
                if (defender > attack)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                    index++;
                    continue;
                }
                if (defender == attack) 
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
        }
    }
}
