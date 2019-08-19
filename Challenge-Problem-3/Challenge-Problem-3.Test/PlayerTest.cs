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
        public void ExecuteNextMoveShouldCallJumpWhenSpaceKeyIsPassedIn()
        {
            Player player = new Player(5, 5);
            
            player.ExecuteNextMove(UserInput.Space);
            
            Assert.AreEqual(3, player.Position.Y);
        }

        [Test]
        public void ReadInputShouldCreateAListOfChars()
        {
            Player player = new Player();
            String inputString = "DSWDD⎵SSSADSSAWS⎵SS⎵SDDA";
            byte[] byteArray = Encoding.UTF8.GetBytes(inputString); 
            MemoryStream inputStream = new MemoryStream(byteArray);

            List<UserInput> userInputs = player.ParsePlayerInput(inputStream);
            
            Assert.AreEqual(UserInput.W, userInputs[2]);
            Assert.AreEqual(UserInput.Space, userInputs[5]);
            Assert.AreEqual(UserInput.A, userInputs[9]);
            Assert.AreEqual(UserInput.S, userInputs[11]);
            Assert.AreEqual(UserInput.D, userInputs[22]);
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