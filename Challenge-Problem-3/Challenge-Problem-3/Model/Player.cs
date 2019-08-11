using System.ComponentModel.Design;
using Challenge_Problem_3.Util;

namespace Challenge_Problem_3
{
    public class Player
    {
        public Coordinate2D Position = new Coordinate2D();

        public Player(uint xPosition, uint yPosition)
        {
            Position.X = xPosition;
            Position.Y = yPosition;
        }

        public void MoveUp()
        {
            if (this.Position.Y > 0)
            {
                this.Position.Y -= 1;
            }
        }
        public void MoveDown()
        {
            this.Position.Y += 1;
        }
        public void MoveLeft()
        {
            if (this.Position.X > 0)
            {
                this.Position.X -= 1;
            }
        }
        public void MoveRight()
        {
            this.Position.Y += 1;
        }
        
        
    }
    
}