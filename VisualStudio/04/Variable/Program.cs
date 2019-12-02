using System;
namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string appleCountDescription = "바구니 안에 담긴 사과의 개수: ";
            Console.Write(appleCountDescription);
            int appleCount = 12; //중단점(F9) - 프로그램 실행을 특정 지점에서 잠시 중단시키기 위해 설정하는 지시자
            Console.WriteLine(appleCount);

            appleCount = appleCount - 2;
            appleCountDescription = "내가 먹고 난 뒤에 " + appleCountDescription;

            Console.Write(appleCountDescription);//F10 한줄씩 코드 실행
            Console.WriteLine(appleCount); //디버그 (F5) 로컬-함수안에 변수표시, 조사식-변수를 드래그하거나 항목추가에 변수명추가
        }
    }
}
