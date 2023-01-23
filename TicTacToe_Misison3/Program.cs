using System;

// Driver Class


namespace TicTacToe_Misison3
{
    class Program
    {
        public static void TESTFunction()
        {
            char[,] array = new char[3, 3];
            array[0, 0] = 'X';
            array[1, 0] = 'X';
            array[2, 0] = 'X';
            Supporting sup = new Supporting();
            Console.WriteLine(sup.determineWinner(array));
        }

        static void Main(string[] args)
        {

            // Testing the program to see if it works
            Program.TESTFunction();

            // Initializing the cCurrentPlayer character variable
            char cCurrentPlayer = ' ';
            
            // Initializing the iPos (position) variable
            int iPos = 0;

            // Initializing the cWinner Variable
            int cWinner = 0;

            // Create a game board array to store the players’ choices (holds markers "X" and "O")
            char[,] aPlayerChoices = new char[3, 3];


            // Initializing the array with ' ' in each spot of the array
            for (int icol=0; icol < 3; icol++)
            {
                for (int irow = 0; irow < 3; irow++)
                {
                    aPlayerChoices[icol, irow] = ' ';
                }
            }

            // Initializing an instance of the Supporting class
            Supporting supporting = new Supporting();





            // Welcome the user to the game
            Console.WriteLine("Welcome to Group 3-3's Tic Tac Toe Game!");


            // Give the user some Instructions on how to play
            Console.WriteLine("In order to say where you want to go, you need to specify the column and then the row (using numbers). For the columns, A = 1, B = 2, C = 3.");


            // START PLAYING

            // setting the current player to 'X' (player 1)
            cCurrentPlayer = 'X';


            // WIN CONDITION OUTER LOOP
            // Check for a winner by calling the method in the supporting class, and notify the players
            cWinner = supporting.determineWinner(aPlayerChoices);


            // If there isn't a winner yet
            while (cWinner == 0)
            {

                // Print the current Board
                supporting.printBoard(aPlayerChoices);

                
                
                bool bOutofSpace = true;

                // Check to see if there are still empty spaces on the board
                for (int icol = 0; icol < 3; icol++)
                {
                    for (int irow = 0; irow < 3; irow++)
                    {
                        if (aPlayerChoices[icol, irow] == ' ')
                        {
                            bOutofSpace = false;
                            break;
                        }
                    }

                    if (bOutofSpace == false)
                    {
                        bOutofSpace = false;
                        break;
                    }

                }

                // No more space on the board (Tie)
                if (bOutofSpace == true)
                {
                    Console.WriteLine("Looks like you tied!!!");
                    break;
                }



                // TURN

                // Ask each player in turn for their choice and update the game board array

                Console.WriteLine("\n\n" + cCurrentPlayer + "'s Turn : ");

                int row = 0;
                int column = 0;

                // initializing the bFreeSpace variable
                bool bFreeSpace = true;
                
                // checking to see if their space is empty
                while (bFreeSpace == true)
                {


                    Console.WriteLine("Input column you want to input:");
                    column = Convert.ToInt32(Console.ReadLine()) - 1;


                    Console.WriteLine("Input row you want to input:");
                    row = Convert.ToInt32(Console.ReadLine()) - 1;


                    if (aPlayerChoices[column, row] == ' ')
                    {
                        // add the player's marker (X or O) (held in cCurrentPlayer) to the array
                         aPlayerChoices[column, row] = cCurrentPlayer;

                        // Now the space is not free
                        bFreeSpace = false;
                    }
                    else
                    {
                        Console.WriteLine("\nHey! You can't go there!!!\n");
                    }



                }


                // Running the determineWinner method from the Supporting class and putting the result in the cWinner variable
                cWinner = supporting.determineWinner(aPlayerChoices);


                if (cWinner == 1)
                {
                    Console.WriteLine("Looks like X's won this time!!!");
                    break;
                }
                else if (cWinner == 2)
                {
                    Console.WriteLine("Looks like O's won this time!!!");
                    break;
                }


                // Change players

                // If the current player is 'X' (Player 1)
                if (cCurrentPlayer == 'X')
                {
                    // Then change the current player to 'O' (Player 2)
                    cCurrentPlayer = 'O';
                }
                // Otherwise (if the current player is 'O' (Plyaer 2))
                else
                {
                    // Then change the current player to 'X' (Player a)
                    cCurrentPlayer = 'X';
                }


            }
            

            

            


            // when a win has occurred and which player won the game


        }
    }
}
