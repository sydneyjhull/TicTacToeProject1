﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProject1
{
    class Support
    {
        //Receive the “board” array from the driver class

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
        public string CheckWin(string[] array)
        {
            string output = "";

            //Horizontal Win Conditions
            if (array[0] == array[1] && array[1] == array[2])
            {
                output = array[0] + " Wins!";
            }
            else if (array[3] == array[4] && array[4] == array[5])
            {
                output = array[3] + " Wins!";
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                output = array[6] + " Wins!";
            }

            //Vertical Win Conditions
            else if (array[0] == array[3] && array[3] == array[6])
            {
                output = array[0] + " Wins!";
            }
            else if (array[1] == array[4] && array[4] == array[7])
            {
                output = array[1] + " Wins!";
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                output = array[2] + " Wins!";
            }

            //Diagonal Win Conditions
            else if (array[0] == array[4] && array[4] == array[8])
            {
                output = array[0] + " Wins!";
            }
            else if (array[2] == array[4] && array[4] == array[6])
            {
                output = array[2] + " Wins!";
            }

            //Tie Condition
            else if (array[0] != "1" && array[1] != "2" && array[2] != "3" && array[3] != "4" && array[4] != "5" && array[5] != "6" && array[6] != "7" && array[7] != "8" && array[8] != "9")
            {
                output = "It's a Draw";
            }

            //No Win Condition
            else
            {
                output = "\n";
            }

            return output;
        }
    }
}