﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrongVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int appleCount = 12;
            int pearCount;

            Console.WriteLine(appleCount);
            Console.WriteLine(pearCount); // 변수에 값을 안 넣고 사용해서 에러!!
        }
    }
}
