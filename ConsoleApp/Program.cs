using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 절대값 기준
            Console.Write("메서드 호출");
            Thread.Sleep(1000); // 시간 정확하지 않음
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출");
            Thread.Sleep(2000);
            Console.SetCursorPosition(3, 2);
            Console.Write("메서드 호출");
        }
    }
}
