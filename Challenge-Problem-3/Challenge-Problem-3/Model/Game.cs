using System;
using System.IO;

namespace Challenge_Problem_3
{
    public static class Game
    {
        private static readonly Player Player = new Player();

        public static void Play()
        {
            Console.Out.WriteLine("Game Started");
            var movesList = Player.ReadInput(new FileStream("PlayerInput.txt", FileMode.Open));
            Player.determineAllMoves(movesList);
            Console.Out.WriteLine("Game Over");
            Console.Out.WriteLine("Player Moved " + Player.TotalSpacesMoved + " units total");
        }

    }
}