using System;

namespace TicTacToeProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Support sp = new Support();
            //Welcome the user to the game
            Console.WriteLine("Let's play Tic-Tac-Toe!");


            //• Create a game board array to store the players’ choices
            string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool gameOver = false;
            sp.PrintArray(gameBoard);

            //• Ask each player in turn for their choice and update the game board array
            int choice = 0;
            int player = 1;
            if (gameOver == false)
            {
                if (player % 2 != 0)
                {
                    Console.WriteLine("Player 1, where do you want to place an X ?:");
                    choice = int.Parse(Console.ReadLine());
                    player++;
                    gameBoard[choice - 1] = "X";
                    sp.PrintArray(gameBoard);
                    sp.CheckWin(gameBoard, gameOver);
                }
                else
                {
                    Console.WriteLine("Player 2, where do you want to place an O ?:");
                    choice = int.Parse(Console.ReadLine());
                    player++;
                    gameBoard[choice - 1] = "O";
                    sp.PrintArray(gameBoard);
                    sp.CheckWin(gameBoard, gameOver);
                }
            }
            //• Print the board by calling the method in the supporting class


            //• Check for a winner by calling the method in the supporting class, and notify the players
            //when a win has occurred and which player won the game

           sp.CheckWin(gameBoard);

        }
    }
}
