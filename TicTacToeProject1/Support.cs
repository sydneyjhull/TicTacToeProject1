using System;
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

        //Contain a method that receives the game board array as input and returns if there is a
        //winner and who it was
    }
}
