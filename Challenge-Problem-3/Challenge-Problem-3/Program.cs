using System;
using System.IO;

namespace Challenge_Problem_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Game Started");
            var player = new Player();
            var movesList = player.ReadInput(new FileStream("/Users/mattleuer/Developer/Challenge-Problem-3/Challenge-Problem-3/Challenge-Problem-3/Util/PlayerInput.txt", FileMode.Open));
            player.determineAllMoves(movesList);
            Console.Out.WriteLine("Game Over");
            Console.Out.WriteLine("Player Moved " + player.CountNumberOfSpacesMoved(movesList) + " units total");
            
            
        }
    }
}