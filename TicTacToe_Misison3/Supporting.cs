using System;
using System.Collections.Generic;
using System.Text;

// Supporting Class

namespace TicTacToe_Misison3
{
    class Supporting
    {
        public void printBoard(char[,] arr)
            // print out a pretty board, subing in arr values for t
        {
            // The squares on the board
            Console.WriteLine("   a     b     c  ");
            Console.WriteLine("      |     |     ");
            Console.WriteLine("1  " + arr[0, 0] + "  |  " + arr[1, 0] + "  |  " + arr[2, 0] + "  ");
            Console.WriteLine(" _____|_____|_____");
            Console.WriteLine("      |     |     ");
            Console.WriteLine("2  " + arr[0, 1] + "  |  " + arr[1, 1] + "  |  " + arr[2, 1] + "  ");
            Console.WriteLine(" _____|_____|_____");
            Console.WriteLine("      |     |     ");
            Console.WriteLine("3  " + arr[0, 2] + "  |  " + arr[1, 2] + "  |  " + arr[2, 2] + "  ");
            Console.WriteLine("      |     |     ");
        }

        public int determineWinner(char[,] arr)
        {
            // winner variable, 0 means no winner, 1 means x winner, 2 means o winner
            // default no winner
            int winner = 0;

            // stores if x or o wins, space if no win
            char winningShape = ' ';

            // check the top left to bottom right diagonal
            if ((arr[0,0] == arr[1,1]) && (arr[0,0] == arr[2,2]) && ((arr[0, 0] == 'X') || (arr[0, 0] == 'O')))
            {
                winningShape = arr[0, 0];
            }

            // check the top right to bottom left diagonal
            if ((arr[2, 0] == arr[1, 1]) && (arr[2, 0] == arr[0, 2]) && ((arr[2, 0] == 'X') || (arr[2, 0] == 'O')))
            {
                winningShape = arr[2, 0];
            }

            // loop through the rows and check if all values in row are equal
            for (int i = 0; i < 3; i++)
            {
                if ((arr[0, i] == arr[1, i]) && (arr[0, i] == arr[2, i]) && ((arr[0, i] == 'X') || (arr[0, i] == 'O')))
                {
                    winningShape = arr[0, i];
                }
            }

            // loop through the cols and check if all values in cols are equal
            for (int i = 0; i < 3; i++)
            {
                if ((arr[i, 0] == arr[i, 1]) && (arr[i, 0] == arr[i, 2]) && ((arr[0, i] == 'X') || (arr[0, i] == 'O')))
                {
                    winningShape = arr[i, 0];
                }
            }

            // check if x or o has won and set the return value
            if (winningShape == 'X')
            {
                winner = 1;
            }
            else if (winningShape == 'O')
            {
                winner = 2;
            }
            
            // 0 = no winner, 1 = x winner, 2 = o winner
            return winner;
        }
    }
}
