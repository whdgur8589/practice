using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[2];
            for (int class1 = 0; class1 < 2; class1++)
            {
                Console.Write(class1 + 1);
                Console.WriteLine("반입니다.");

                for (int student = 0; student < 2; student++)
                {   
                    Console.WriteLine("점수를 입력하시오");
                    score[student] = int.Parse(Console.ReadLine());
                }
            }
            int [] totalScore = new int[2];
            int[] averageScore = new int[2];
            for (int class1 = 0; class1 < 2; class1++)
            {
                for (int student = 0; student < 2; student++)
                {
                    totalScore[class1] = totalScore[class1] + score[student];
                }
                averageScore[class1] = totalScore[class1] / 2;
                
            }

            Console.WriteLine("1반 평균은?: ");
            Console.WriteLine(averageScore[0]);

            Console.WriteLine("2반 평균은?: ");
            Console.WriteLine(averageScore[1]);

        }
    }
}
