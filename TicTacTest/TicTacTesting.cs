using System;
using Xunit;
using Lab04_TicTacToe;

namespace TicTacTest
{
    public class TicTacTesting
    {
        [Fact]
        public void TestGameBoardForWinners()
        {
            Board testBoard = new Board();
            testBoard.GameBoard  = new string[,] {
                    { "X", "X", "X"},
                    { "4", "5", "6"},
                    { "7", "8", "9"},                
                   };
            Game testGame = new Game(new Player(), new Player());
            testGame.Board = testBoard;
            Assert.True(testGame.CheckForWinner(testBoard));
        }
        [Fact]
        public void PlayersSwitchBetweenTurns()
        {
            //Set PlayerOne.isTurn to false. Test to verify.
            //Ran SwitchPlayer.  Tested PlayerOne for True.
            Game testGame = new Game(new Player(), new Player());
            testGame.PlayerOne.IsTurn = false;
            Assert.False(testGame.PlayerOne.IsTurn);
            testGame.SwitchPlayer();
            Assert.True(testGame.PlayerOne.IsTurn);
        }
        [Fact]
        public void TestToConfirmProperLocation()
        {
            Player testPlayer = new Player();
            Position testPosition = new Position(2,0);
            Assert.Equal(testPosition.Column, Player.PositionForNumber(7).Column);
            Assert.Equal(testPosition.Row, Player.PositionForNumber(7).Row);
        }
        [Fact]
        public void TestForAccurateMarker()
        {
            Player testPlayer = new Player();
            testPlayer.Marker = "X";
            Assert.Equal("X", testPlayer.Marker);
        }
    }
}
