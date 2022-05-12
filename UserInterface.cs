using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
   


    public class UserInterface
    {
        static int flag = 0;
        

        bool isRunning = true;

        int playersTurn = 0;

        
    public void Run()
    {
    CreateBoard();
    
    
   

    while (isRunning)
    { 
        if (playersTurn % 2 == 0)
        {
            string input = Console.ReadLine();
            PlaceChoice(input);
            CreateBoard();
            playersTurn++; 
        }
        else if (playersTurn % 2 != 0)
        {
            string input = Console.ReadLine();
            PlaceChoice2(input);
            CreateBoard();
            playersTurn++;
        }
        
            
        
        // // Console.WriteLine(CheckWin());
        // string input = Console.ReadLine();
        // PlaceChoice(input);
        // PlaceChoice2(input);
        // CreateBoard();
        if (CheckWin() == 1)
        {
            // Console.Clear();
            Console.WriteLine("Player O Wins");
        }   else if (CheckWin() == 2)
        {
            // Console.Clear();
            Console.WriteLine("Player X Wins");
        }
            // CheckStatus();
    }
    flag = CheckWin();
    }

    // while (flag != 1 && flag != -1);
    // Console.Clear();
    // CreateBoard(); 

// public void CheckStatus()
// {
// if (winFlag == true)
// {
//     Console.WriteLine("Somebody won");
// }
// }
        static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void CreateBoard()
        {
            Console.WriteLine("     {0}     |       {1}     |       {2}     ", pos[1], pos[2], pos[3]);
            Console.WriteLine("=======================================");
            Console.WriteLine("     {0}     |       {1}     |       {2}     ", pos[4], pos[5], pos[6]);
            Console.WriteLine("=======================================");
            Console.WriteLine("     {0}     |       {1}     |       {2}     ", pos[7], pos[8], pos[9]);
        }

        public string PlaceChoice(string x)
        {
            switch (x)
            {
                case "1":
                    pos[1] = "O";
                    return pos[1];
                    break;
                case "2":
                    pos[2] = "O";
                    return pos[2];
                    break;
                case "3":
                    pos[3] = "O";
                    return pos[3];
                    break;
                case "4":
                    pos[4] = "O";
                    return pos[4];
                    break;
                case "5":
                    pos[5] = "O";
                    return pos[5];
                    break;
                case "6":
                    pos[6] = "O";
                    return pos[6];
                    break;
                case "7":
                    pos[7] = "O";
                    return pos[7];
                    break;
                case "8":
                    pos[8] = "O";
                    return pos[8];
                    break;
                case "9":
                    pos[9] = "O";
                    return pos[9];
                    break;
                default:
                    return "We all lose.";
                    break;
            }
        }

        public string PlaceChoice2(string y)
        {
            switch (y)
            {
                case "1":
                    pos[1] = "X";
                    return pos[1];
                    break;
                case "2":
                    pos[2] = "X";
                    return pos[2];
                    break;
                case "3":
                    pos[3] = "X";
                    return pos[3];
                    break;
                case "4":
                    pos[4] = "X";
                    return pos[4];
                    break;
                case "5":
                    pos[5] = "X";
                    return pos[5];
                    break;
                case "6":
                    pos[6] = "X";
                    return pos[6];
                    break;
                case "7":
                    pos[7] = "X";
                    return pos[7];
                    break;
                case "8":
                    pos[8] = "X";
                    return pos[8];
                    break;
                case "9":
                    pos[9] = "X";
                    return pos[9];
                    break;
                default:
                    return "We all lose.";
                    break;
            }
        }

        static int CheckWin() // Win checker method ================================================
    {
        if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O") // Horizontal ----------------------------------------
        {
            return 1;
            
        }
        else if (pos[4] == "O" && pos[5] == "O" && pos[6] == "O")
        {
            return 1;
        }
        else if(pos[7] == "O" && pos[8] == "O" && pos[9] == "O")
        {
            return 1;
        }

        else if(pos[1] == "O" && pos[5] == "O" && pos[9] == "O") // Diagonal -----------------------------------------
        {
            return 1;
        }
        else if(pos[7] == "O" && pos[5] == "O" && pos[3] == "O")
        {
            return 1;
        }

        else if(pos[1] == "O" && pos[4] == "O" && pos[7] == "O")// Coloumns ------------------------------------------
        {
            return 1;
        }
        else if(pos[2] == "O" && pos[5] == "O" && pos[8] == "O")
        {
            return 1;
        }
        else if(pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
        {
            return 1;
        }

        if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X") // Horizontal ----------------------------------------
        {
            return 2;
        }
        else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
        {
            return 2;
        }
        else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
        {
            return 2;
        }

        else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X") // Diagonal -----------------------------------------
        {
            return 2;
        }
        else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
        {
            return 2;
        }

        else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") // Coloumns ------------------------------------------
        {
            return 2;
        }
        else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
        {
            return 2;
        }
        else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
        {
            return 2;
        }
        else // No winner ----------------------------------------------
        {
            return 0;
        }
    }
    
    }
}




