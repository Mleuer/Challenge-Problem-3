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
            var movesList = Player.ParsePlayerInput(new FileStream("PlayerInput.txt", FileMode.Open));
            Player.ExecuteAllMoves(movesList);
            Console.Out.WriteLine("Game Over");
            Console.Out.WriteLine("Player Moved " + Player.TotalSpacesMoved + " units total");
        }

    }
}