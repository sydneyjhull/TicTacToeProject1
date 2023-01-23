using System;

namespace TicTacToeProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome the user to the game
            Console.WriteLine("Let's play Tic-Tac-Toe!");

            //• Create a game board array to store the players’ choices
            string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //• Ask each player in turn for their choice and update the game board array
            Console.WriteLine("Player 1, where do you want to place an X?:");
            string placeX = "";
            placeX = Console.ReadLine();

            Console.WriteLine("Player 2, where do you want to place an O?:");
            string placeO = "";
            placeO = Console.ReadLine();
            //• Print the board by calling the method in the supporting class
            //• Check for a winner by calling the method in the supporting class, and notify the players
            //when a win has occurred and which player won the game
        }
    }
}
