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
        //    ConsoleKey key;
        //    do
        //    {
        //        key = Console.ReadKey(true).Key;
        //        //Console.WriteLine(key);
        //        Console.WriteLine(key.ToString());
        //    } while (key!=ConsoleKey.Escape);

            Console.SetWindowSize(60, 60);
            Console.SetBufferSize(100, 100);
            Console.SetCursorPosition(20, 20);
            Console.WriteLine("Привет!");
            Console.Write("Нажмите любую клавишу...");

            Console.ReadKey(true);
        }
    }
}
