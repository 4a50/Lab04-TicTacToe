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
            bool playAgain = false;
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            do
            {
                playAgain = false;
                Player p1 = GetPlayers(1);
                Player p2 = GetPlayers(2);
                Game ticTacEry = new Game(p1, p2);
                Player winner = ticTacEry.Play();
                if (winner.Name == "Draw")
                {
                    Console.WriteLine("It's a Draw Partner!");
                }
                else
                {
                    Console.WriteLine($"Hooray!! {winner.Name} win!");

                }
                Console.WriteLine("Do you want to play again ? (Y / N)");
                if (Console.ReadLine().ToLower() == "y") playAgain = true;
             } while (playAgain);
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }
        static Player GetPlayers(int playerNum)
        {
            Player newTicTacToeFan = new Player();
            Console.Write($"Enter name for player {playerNum}: ");
            newTicTacToeFan.Name = Console.ReadLine();
            if (playerNum == 1) { newTicTacToeFan.Marker = "X"; }
            else { newTicTacToeFan.Marker = "O"; }
            return newTicTacToeFan;
        }

    }
}
