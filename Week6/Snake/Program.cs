using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program : GameState
    {
        static void Main(string[] args)
        {
            GameState gameState = new GameState();

            while (!end)
            {
                gameState.Draw();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                gameState.PressedKey(consoleKeyInfo);
            }
        }
    }
}