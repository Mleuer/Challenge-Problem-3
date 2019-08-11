using System;
using System.Collections.Generic;
using System.IO;
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
        public Player(uint xPosition, uint yPosition)
        {
            Position.X = xPosition;
            Position.Y = yPosition;
        }

        public void MoveUp()
        {
            if (Position.Y > 0)
            {
                Position.Y -= 1;
            }
        }
        public void Jump()
        {
            if (Position.Y >= 2)
            {
                Position.Y -= 2;
            }
        }
        public void MoveDown()
        {
            Position.Y += 1;
        }
        public void MoveLeft()
        {
            if (Position.X > 0)
            {
                Position.X -= 1;
            }
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
                    break;
                case 'A':
                    MoveLeft();
                    break;
                case 'S':
                    MoveDown();
                    break;
                case 'D':
                    MoveRight();
                    break;
                case ' ':
                    Jump();
                    break;
            }
        }
        public List<char> ReadInput(FileStream playerInput)
        {
            System.IO.StreamReader streamReader = new StreamReader(playerInput);
            String line = streamReader.ReadLine();
            char key = Char.Parse(line);
            List<char> characters = new List<char>();
            characters.Add(key);
            
            while (line != null) {
                line = streamReader.ReadLine();
                if (line != null)
                {
                    key = char.Parse(line);
                    characters.Add(key);
                }
                
            }

            return characters;
        }
        
        
        
    }
    
}