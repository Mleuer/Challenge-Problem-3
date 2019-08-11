using NUnit.Framework;

namespace Challenge_Problem_3.Test
{
    public class PlayerTest
    {
        [Test]
        public void MoveUpShouldSubtractOneFromPlayerYPosition()
        {
            Player player = new Player(1, 1);
            
            player.MoveUp();

            Assert.AreEqual(0, player.Position.Y);
        }
        
        [Test]
        public void MoveUpShouldDoNothingIfPlayerYPositionIsAtZero()
        {
            Player player = new Player(1, 0);
            
            player.MoveUp();

            Assert.AreEqual(0, player.Position.Y);
        }
    }
}