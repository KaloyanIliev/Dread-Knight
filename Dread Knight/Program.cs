using System;
using Dread_Knight;

namespace Dread_Knight
{
    class Program
    {
        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 35;
            Console.BufferWidth = Console.WindowWidth = 125;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "KILLING NINJAS";
            Animation.FirstStage();

            int numberOfPlayers = Intro.Menu();

            if (numberOfPlayers == 1)
            {
                MultyPlayer.MultyPlay();
            }
            else
            {
                MultyPlayer.MultyPlay(true);
            }
        }
    }
}