using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            const int SnakeStateTotal = 3;
            const int SnakeState1 = 0;
            const int SnakeState2 = 1;
            const int SnakeState3 = 2;
            const int SnakeRow = 5;
            const int SnakeMove= 50;
            const int SnakeSleepTime = 1000;

            int x = SnakeState1;
            while (x < SnakeMove)
            {
                Console.Clear();
                Console.SetCursorPosition(x, SnakeRow);

                switch(x% SnakeStateTotal)
                {
                    case SnakeState1:
                        Console.WriteLine("__0");
                        break;
                    case SnakeState2:
                        Console.WriteLine("_^0");
                        break;
                    case SnakeState3:
                        Console.WriteLine("^_0");
                        break;
                }


                Thread.Sleep(SnakeSleepTime);
                x++;
            }
        }
    }
}
