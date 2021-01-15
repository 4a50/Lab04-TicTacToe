using System;

// get player input
// switch cases
// update array with characters
// check for valid player input
// check for valid player placement
// check for winner

namespace Lab04_TicTacToe
{
    public class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player Winner { get; set; }
        public Board Board { get; set; }


        /// <summary>
        /// Require 2 players and a board to start a game. 
        /// </summary>
        /// <param name="p1">Player 1</param>
        /// <param name="p2">Player 2</param>
        public Game(Player p1, Player p2)
        {
            PlayerOne = p1;
            PlayerTwo = p2;
            Board = new Board();
        }

        /// <summary>
        /// Activate the Play of the game
        /// </summary>
        /// <returns>Winner</returns>
        public Player Play()
        {

            //TODO: Complete this method and utilize the rest of the class structure to play the game.
            bool isValid = false;
            //Determine Whose Turn
            do
            {
                Console.WriteLine($"{player.Name} pick you spot:");
                string userInput = Console.Readline();
                isValid = GetValidPosition(userInput);
                if (!isValid) Console.WriteLine("Invalid Entry.  Try again");
            } while (!isValid);

            UpdateMatrix(userInput);


            /*
             * Complete this method by constructing the logic for the actual playing of Tic Tac Toe. 
             * 
             * A few things to get you started:
            1. A turn consists of a player picking a position on the board with their designated marker. 
            2. Display the board after every turn to show the most up to date state of the game
            3. Once a Winner is determined, display the board one final time and return a winner

            Few additional hints:
                Be sure to keep track of the number of turns that have been taken to determine if a draw is required
                and make sure that the game continues while there are unmarked spots on the board. 

            Use any and all pre-existing methods in this program to help construct the method logic. 
             */
        }

        public int[] GetLocationOnBoard(string userInput)
        {

            switch (userInput)
            {
                case "1":
                    return new int[] { 0, 0 };
                    break;
                case "2":
                    return new int[] { 0, 1 };
                    break;
                case "3":
                    return new int[] { 0, 2 };
                    break;
                case "4":
                    return new int[] { 1, 0 };
                    break;
                case "5":
                    return new int[] { 1, 1 };
                    break;
                case "6":
                    return new int[] { 1, 2 };
                    break;
                case "7":
                    return new int[] { 2, 0 };
                    break;
                case "8":
                    return new int[] { 2, 1 };
                    break;
                case "9":
                    return new int[] { 2, 2 };
                    break;

            }
            public string UpdateMatrix(int[] loc, string playerMark)
            {
                string testLocation = Gameboard[loc[0], loc[1]];
                Gameboard[loc[0], loc[1]] = playerMark;
                return testLocation;

            }
            public bool GetValidPosition(string userInput)
            {
                int number = 0;
                if (!int.TryParse(userInput, int number)) return false;
                if (number < 1 || number > 10) return false;
                return true;
            }
            /// <summary>
            /// Check if winner exists
            /// </summary>
            /// <param name="board">current state of the board</param>
            /// <returns>if winner exists</returns>
            public bool CheckForWinner(Board board)
            {
                int[][] winners = new int[][]
                {
                new[] {1,2,3},
                new[] {4,5,6},
                new[] {7,8,9},

                new[] {1,4,7},
                new[] {2,5,8},
                new[] {3,6,9},

                new[] {1,5,9},
                new[] {3,5,7}
                };

                // Given all the winning conditions, Determine the winning logic. 
                for (int i = 0; i < winners.Length; i++)
                {
                    Position p1 = Player.PositionForNumber(winners[i][0]);
                    Position p2 = Player.PositionForNumber(winners[i][1]);
                    Position p3 = Player.PositionForNumber(winners[i][2]);

                    string a = Board.GameBoard[p1.Row, p1.Column];
                    string b = Board.GameBoard[p2.Row, p2.Column];
                    string c = Board.GameBoard[p3.Row, p3.Column];

                    // TODO:  Determine a winner has been reached. 
                    // return true if a winner has been reached. 

                }

                return false;
            }


            /// <summary>
            /// Determine next player
            /// </summary>
            /// <returns>next player</returns>
            public Player NextPlayer()
            {
                return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
            }

            /// <summary>
            /// End one players turn and activate the other
            /// </summary>
            public void SwitchPlayer()
            {
                if (PlayerOne.IsTurn)
                {

                    PlayerOne.IsTurn = false;


                    PlayerTwo.IsTurn = true;
                }
                else
                {
                    PlayerOne.IsTurn = true;
                    PlayerTwo.IsTurn = false;
                }
            }


        }
    }
