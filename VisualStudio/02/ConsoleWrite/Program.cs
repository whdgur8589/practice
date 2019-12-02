using System;

namespace ConsoleWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WriteLine을 쓰면");
            Console.WriteLine("한 줄씩 나옵니다");
            Console.Write("Write는 아닙니다");
            Console.Write("이어져서 나오져?");
            Console.WriteLine("Write 뒤에 WriteLine을 썼습니다.");
            //2-5
            Console.Write("바구니 안에 담긴 사과의 개수: ");
            Console.WriteLine("12");

            Console.Write("사과 바구니의 무게: ");
            Console.WriteLine("1.32");
            Console.WriteLine("!@#$%&&"); //특문 테스트

            //그림 2-3
            Console.WriteLine("큰따옴표 \"출력"); //("큰따옴표 " 출력") << 오류 //오류 메세지 더블 클릭시 커서가 오류가 있는 코드로 이동
            Console.WriteLine("\\\'\""); //\'"
        }
    }
}
