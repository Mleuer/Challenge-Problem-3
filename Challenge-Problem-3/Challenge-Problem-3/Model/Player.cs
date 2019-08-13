using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Challenge_Problem_3.Util;

namespace Challenge_Problem_3
{
    public class Player
    {
        public Coordinate2D Position = new Coordinate2D();

        public Player()
        {
            Position.X = 0;
            Position.Y = 0;
        }
        public Player(int xPosition, int yPosition)
        {
            Position.X = xPosition;
            Position.Y = yPosition;
        }

        public void MoveUp()
        {
            Position.Y -= 1;
        }
        public void Jump()
        {
            Position.Y -= 2;
        }
        public void MoveDown()
        {
            Position.Y += 1;
        }
        public void MoveLeft()
        {
            Position.X -= 1;
        }
        public void MoveRight()
        {
            Position.X += 1;
        }

        public void DetermineNextMove(char key)
        {
            char upperKey = char.ToUpper(key);
            switch (upperKey)
            {
                case 'W':
                    MoveUp();
                    printPosition();
                    break;
                case 'A':
                    MoveLeft();
                    printPosition();
                    break;
                case 'S':
                    MoveDown();
                    printPosition();
                    break;
                case 'D':
                    MoveRight();
                    printPosition();
                    break;
                case '⎵':
                    Jump();
                    printPosition();
                    break;
            }
        }

        private void printPosition()
        {
            Console.Out.WriteLine("Player location: (" + Position.X + ", " + Position.Y + ")" );
        }

        public int CountNumberOfSpacesMoved(List<char> moveList)
        {
            int spacesMoved = 0;
            foreach (var character in moveList)
            {
                if (character == 'W' || character == 'A' || character == 'S' || character == 'D')
                {
                    spacesMoved ++;
                }
                else
                {
                    spacesMoved += 2;
                }
            }
            return spacesMoved;
        }
        public List<char> ReadInput(Stream playerInput)
        {
            System.IO.StreamReader streamReader = new StreamReader(playerInput);
            String playerInputString = streamReader.ReadToEnd();
            string trimmedPlayerInputString = Regex.Replace(playerInputString, @"\t|\n|\r", "");
            List<char> characters = new List<char>();

            foreach (var character in trimmedPlayerInputString)
            {
                characters.Add(character);
            }
            return characters;
        }

        public void determineAllMoves(List<char> chars)
        {
            printPosition();
            foreach (var character in chars)
            {
                DetermineNextMove(character);
            }
        }
        
    }
    
}