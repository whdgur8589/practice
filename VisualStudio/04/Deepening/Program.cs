using System;

namespace Deepening
{
    class Program
    {
        static void Main(string[] args)
        {
            //강의 보기전 코드 (더 세분화 시켜서 프로그래밍을 해야할 것 같다)
            /* int coin = 10;
            coin = coin / 2 + 1;
            coin = coin / 2 - 2;
            Console.WriteLine(coin); */

            //강의 코드
            int coin = 10;
            string coinMessage = "주머니 속 동전의 개수: ";
            Console.Write(coinMessage);
            Console.WriteLine(coin);

            int aramCoin = (coin / 2);
            aramCoin = aramCoin - 1;
            Console.Write("아람이가 가져간 동전의 개수: ");
            Console.WriteLine(aramCoin);

            coin = coin - aramCoin;

            int uramCoin = (coin / 2);
            uramCoin = uramCoin + 2;
            Console.Write("우람이가 가져간 동전의 개수: ");
            Console.WriteLine(uramCoin);

            coin = coin - uramCoin;

            Console.Write(coinMessage);
            Console.WriteLine(coin);

        }
    }
}
