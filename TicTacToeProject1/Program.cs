﻿using System;

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

            //• Ask each player in turn for their choice and update the game board array
            if (CheckWin != true)
            {
                int choice = 0;
                int player = 1;
                if (player % 2 != 0)
                {
                    Console.WriteLine("Player 1, where do you want to place an X ?:");
                    choice = int.Parse(Console.ReadLine());
                    player++;
                    gameBoard[choice] = "X";
                    sp.CheckWin(gameBoard);
                } 
                else
                {
                    Console.WriteLine("Player 2, where do you want to place an X ?:");
                    choice = int.Parse(Console.ReadLine());
                    player++;
                    gameBoard[choice] = "O";
                    sp.CheckWin(gameBoard);
                }
            }
            //• Print the board by calling the method in the supporting class
            Console.WriteLine(sp.PrintArray(gameBoard));

            //• Check for a winner by calling the method in the supporting class, and notify the players
            //when a win has occurred and which player won the game

        }
    }
}
