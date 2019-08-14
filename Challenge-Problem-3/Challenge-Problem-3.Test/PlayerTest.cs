using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Challenge_Problem_3.Util;
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
        public void JumpShouldSubtractTwoFromPlayerYPosition()
        {
            Player player = new Player(1, 2);
            
            player.Jump();

            Assert.AreEqual(0, player.Position.Y);
        }

        [Test]
        public void MoveDownShouldAddOneToPlayerYPosition()
        {
            Player player = new Player(1, 1);
            
            player.MoveDown();

            Assert.AreEqual(2, player.Position.Y);
        }
        
        [Test]
        public void MoveLeftShouldSubractOneFromPlayerXPosition()
        {
            Player player = new Player(1, 1);
            
            player.MoveLeft();

            Assert.AreEqual(0, player.Position.X);
        }

        [Test]
        public void MoveRightShouldAddOneToPlayerXPosition()
        {
            Player player = new Player(1, 1);
            
            player.MoveRight();

            Assert.AreEqual(2, player.Position.X);
        }

        [Test]
        public void DetermineNextMoveShouldCallJumpWhenSpaceKeyIsPassedIn()
        {
            Player player = new Player(5, 5);
            
            player.DetermineNextMove('⎵');
            
            Assert.AreEqual(3, player.Position.Y);
        }

        [Test]
        public void ReadInputShouldCreateAListOfChars()
        {
            Player player = new Player();
            String inputString = "DSWDD⎵SSSADSSAWS⎵SS⎵SDDA";
            byte[] byteArray = Encoding.UTF8.GetBytes(inputString); 
            MemoryStream inputStream = new MemoryStream(byteArray);
            char spaceCharacter = Char.Parse(Char.ConvertFromUtf32(9141));

            List<char> chars = player.ReadInput(inputStream);
            
            Assert.AreEqual('W', chars[2]);
            Assert.AreEqual(spaceCharacter, chars[5]);
            Assert.AreEqual('A', chars[9]);
            Assert.AreEqual('S', chars[11]);
            Assert.AreEqual('D', chars[22]);
        }

        [Test]
        public void IncrementNumberOfSpacesMovedShouldAdd3ToThePlayersTotalSpacesMovedWhenMoveRightIsCalled3Times()
        {
            Player player = new Player();

            player.MoveRight();
            player.MoveRight();
            player.MoveRight();
            
            Assert.AreEqual(3, player.TotalSpacesMoved);
            
        }
    }
}