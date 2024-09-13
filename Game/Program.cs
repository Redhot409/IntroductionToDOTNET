using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;

            //генерация случайного числа
           // 1) создаем объект класса рандом:
            Random rand =new Random();

            // 2) метод next возвращает случайное число типа int
            int x = rand.Next(Console.BufferWidth);
            int y = rand.Next(Console.BufferHeight);
            Console.WriteLine($"X={x}, Y={y}");
            Console.SetCursorPosition(x, y);
            char symbol = (char)2;
            Console.WriteLine(symbol);
            //Console.WriteLine((char)2);
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key);
                //Console.WriteLine(key.ToString());
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W: y--;break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S: y++;break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: x-=2;break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D: x+=2;break; 
                    
                }
                
                if (y < 0) y = 1;
                if(x<0) x=0;               
                if (y > Console.BufferHeight - 1) y = Console.BufferHeight - 1;
                if(x>Console.BufferWidth-1) x= Console.BufferWidth - 1;
                Console.Clear();
                Console.WriteLine($"X={x}, Y={y}");
                Console.SetCursorPosition(x,y);
                Console.Write(symbol);
                


            } while (key!=ConsoleKey.Escape);

            
        }
    }
}
