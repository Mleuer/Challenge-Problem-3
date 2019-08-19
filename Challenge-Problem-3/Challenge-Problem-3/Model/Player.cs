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
        public int TotalSpacesMoved;

        public Player()
        {
            TotalSpacesMoved = 0;
        }
        public Player(int xPosition, int yPosition)
        {
            Position = new Coordinate2D(xPosition, yPosition);
            TotalSpacesMoved = 0;
        }

        public void MoveUp()
        {
            Position.Y -= 1;
            IncrementNumberOfSpacesMovedByGivenNumber(1);
        }
        public void Jump()
        {
            Position.Y -= 2;
            IncrementNumberOfSpacesMovedByGivenNumber(2);
        }
        public void MoveDown()
        {
            Position.Y += 1;
            IncrementNumberOfSpacesMovedByGivenNumber(1);
        }
        public void MoveLeft()
        {
            Position.X -= 1;
            IncrementNumberOfSpacesMovedByGivenNumber(1);
        }
        public void MoveRight()
        {
            Position.X += 1;
            IncrementNumberOfSpacesMovedByGivenNumber(1);
        }

        public void ExecuteNextMove(Enum key)
        {
            switch (key)
            {
                case UserInput.W:
                    MoveUp();
                    printPosition();
                    break;
                case UserInput.A:
                    MoveLeft();
                    printPosition();
                    break;
                case UserInput.S:
                    MoveDown();
                    printPosition();
                    break;
                case UserInput.D:
                    MoveRight();
                    printPosition();
                    break;
                case UserInput.Space:
                    Jump();
                    printPosition();
                    break;
            }
        }

        private void printPosition()
        {
            Console.Out.WriteLine("Player location: (" + Position.X + ", " + Position.Y + ")" );
        }

        private void IncrementNumberOfSpacesMovedByGivenNumber(int number)
        {
            TotalSpacesMoved += number;
        }
        public List<UserInput> ParsePlayerInput(Stream playerInput)
        {
            System.IO.StreamReader streamReader = new StreamReader(playerInput);
            String playerInputString = streamReader.ReadToEnd();
            string trimmedPlayerInputString = Regex.Replace(playerInputString, @"\t|\n|\r", "");
            var userInputs = new List<UserInput>();

            foreach (var character in trimmedPlayerInputString)
            {
                UserInput input = UserInputFactory.createFromChar(character);
                userInputs.Add(input);
            }
            return userInputs;
        }

        public void ExecuteAllMoves(List<UserInput> userInputs)
        {
            printPosition();
            foreach (var character in userInputs)
            {
                ExecuteNextMove(character);
            }
        }

        public void ExecutePlayerInput(Stream playerInput)
        {
            var movesList = ParsePlayerInput(playerInput);
            ExecuteAllMoves(movesList);
        }
        
    }
    
}