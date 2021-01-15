using System;


namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {

            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            Player p1 = GetPlayers(1);
            Player p2 = GetPlayers(2);
            Game ticTacEry = new Game(p1, p2);


            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }
        static Player GetPlayers(int playerNum)
        {
            Player newTicTacToeFan = new Player();
            Console.Write($"Enter name for player {playerNum}: ");
            newTicTacToeFan.Name = Console.ReadLine();
            return newTicTacToeFan;
        }

    }
}
