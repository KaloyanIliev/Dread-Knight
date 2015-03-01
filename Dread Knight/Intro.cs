using System;
using System.Threading;


namespace Dread_Knight
{
    class Intro
    {
        static void PrintOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Black)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(s);
        }

        internal static int Menu()
        {
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();
            bool isFirstTime = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("('0.0)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(70, 21);
                Console.WriteLine("(■_■')");
                if (isFirstTime) Thread.Sleep(950);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("── Hello, Doncho!");
                if (isFirstTime) Thread.Sleep(950);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(70, 18);
                Console.WriteLine("── Hello, Dread Knight!");
                if (isFirstTime) Thread.Sleep(950);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 19);
                Console.WriteLine("── Do you want some action?");
                if (isFirstTime) Thread.Sleep(950);
                Console.SetCursorPosition(53, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   PRESS Y or N");
                Console.SetCursorPosition(40, 12);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("(Y for \"SinglePlayer\" or N for \"MultyPlayer\")");
                Console.SetCursorPosition(Console.WindowWidth / 2, 12);
                pressedKey = Console.ReadKey(true);
                isFirstTime = false;
            } while (pressedKey.Key != ConsoleKey.Y && pressedKey.Key != ConsoleKey.N);
            
            Console.Write(char.ToUpper(pressedKey.KeyChar));
            Console.ForegroundColor = ConsoleColor.Green;
            if (pressedKey.Key == ConsoleKey.Y)
            {
                Console.SetCursorPosition(70, 19);
                Console.WriteLine("── Sir, YES, Sir!");
                Thread.Sleep(1500);
                Console.Clear();
                return 2;
            }
            if (pressedKey.Key == ConsoleKey.N)
            {
                Console.SetCursorPosition(70, 19);
                Console.WriteLine("── I've got some bad news, Sir.");
                Thread.Sleep(1500);
                Console.Clear();
                return 1;
            }
            return 1;
        }
    }
}
