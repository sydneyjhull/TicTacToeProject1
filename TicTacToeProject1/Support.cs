using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProject1
{
    class Support
    {

        //Contain a method that prints the board based on the information passed in
        public void PrintArray(string[] array)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", array[0], array[1], array[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", array[3], array[4], array[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", array[6], array[7], array[8]);
            Console.WriteLine("     |     |     ");
        }

        //Contain a method that receives the game board array as input and returns if there is a winner and who it was
        public string[] CheckWin(string[] array, string gameOver) //Inputs are the array of values in the board, along with a string containing whether someone lost or won
        {
            string output = ""; //Output will return a statement about who won

            //Horizontal Win Conditions in Tic Tac Toe
            if (array[0] == array[1] && array[1] == array[2])
            {
                output = array[0] + " Wins!";
                gameOver = "true";
            }
            else if (array[3] == array[4] && array[4] == array[5])
            {
                output = array[3] + " Wins!";
                gameOver = "true";
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                output = array[6] + " Wins!";
                gameOver = "true";
            }

            //Vertical Win Conditions in Tic Tac Toe
            else if (array[0] == array[3] && array[3] == array[6])
            {
                output = array[0] + " Wins!";
                gameOver = "true";
            }
            else if (array[1] == array[4] && array[4] == array[7])
            {
                output = array[1] + " Wins!";
                gameOver = "true";
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                output = array[2] + " Wins!";
                gameOver = "true";
            }

            //Diagonal Win Conditions in Tic Tac Toe
            else if (array[0] == array[4] && array[4] == array[8])
            {
                output = array[0] + " Wins!";
                gameOver = "true";
            }
            else if (array[2] == array[4] && array[4] == array[6])
            {
                output = array[2] + " Wins!";
                gameOver = "true";
            }

            //Tie Condition, if both X and O can't win
            else if (array[0] != "1" && array[1] != "2" && array[2] != "3" && array[3] != "4" && array[4] != "5" && array[5] != "6" && array[6] != "7" && array[7] != "8" && array[8] != "9")
            {
                output = "It's a Draw";
                gameOver = "true";
            }

            //No Win Condition. If neither X nor O wins the game, but there are moves that can still be made
            else
            {
                output = "\n";
            }

            string[] outputArray = { output, gameOver };//Returning two variables that will show whether someone has won to escape the loop, along with the output string to say who won

            return outputArray;
        }
    }
}
