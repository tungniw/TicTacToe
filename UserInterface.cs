using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class UserInterface
    {
        int flag = 0;

        int input;

        bool isRunning = true;

        int playersTurn = 0;




        public void Run()
        {
            Console.WriteLine("Player 1 you will be O... What is your name?");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Player 2 you will be X... What is your name?");
            string player2Name = Console.ReadLine();
            

            
            {

                {
                    while (isRunning)
                    {
                        
                        CreateBoard();
                        input = int.Parse(Console.ReadLine());

                        if (pos[input] != "X" && pos[input] != "O")
                        {
                            if (playersTurn % 2 == 0)
                            {
                                PlaceChoice(input.ToString(), "O");
                                CreateBoard();
                                Console.Clear();
                                playersTurn++;
                            }
                            else if (playersTurn % 2 != 0)
                            {
                                PlaceChoice(input.ToString(), "X");
                                CreateBoard();
                                Console.Clear();
                                playersTurn++;
                            }

                        }

                        else
                        {
                            Console.WriteLine("Sorry that spot is already taken.");
                        }

                        if (CheckWin() == 1)
                        {
                            Console.WriteLine($"{player1Name} wins!");
                            Console.WriteLine("press any button to play again");
                            Console.ReadKey();
                            ClearBoard();
                            Console.Clear();

                        }
                        else if (CheckWin() == 2)
                        {
                            // Console.Clear();
                            Console.WriteLine($"{player2Name} wins!");
                            Console.WriteLine("press any button to play again");
                            Console.WriteLine();
                            Console.ReadKey();
                            ClearBoard();
                            Console.Clear();

                        }
                        else if (CheckWin() == 5)
                        {
                            Console.WriteLine("its a draw");
                            Console.WriteLine("press any button to play again");
                            ClearBoard();
                            Console.ReadKey();

                        }

                    }
                    flag = CheckWin();
                }
            }
        }


        string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public void CreateBoard()
        {
            
            Console.WriteLine("     {0}     |       {1}     |       {2}     ", pos[1], pos[2], pos[3]);
            Console.WriteLine("=======================================");
            Console.WriteLine("     {0}     |       {1}     |       {2}     ", pos[4], pos[5], pos[6]);
            Console.WriteLine("=======================================");
            Console.WriteLine("     {0}     |       {1}     |       {2}     ", pos[7], pos[8], pos[9]);
        }

        public void ClearBoard()
        {
            pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        }

        public string PlaceChoice(string x, string y)
        {
            switch (x)
            {
                case "1":
                    pos[1] = y;
                    return pos[1];
                    break;
                case "2":
                    pos[2] = y;
                    return pos[2];
                    break;
                case "3":
                    pos[3] = y;
                    return pos[3];
                    break;
                case "4":
                    pos[4] = y;
                    return pos[4];
                    break;
                case "5":
                    pos[5] = y;
                    return pos[5];
                    break;
                case "6":
                    pos[6] = y;
                    return pos[6];
                    break;
                case "7":
                    pos[7] = y;
                    return pos[7];
                    break;
                case "8":
                    pos[8] = y;
                    return pos[8];
                    break;
                case "9":
                    pos[9] = y;
                    return pos[9];
                    break;
                default:
                    return "We all lose.";
                    break;
            }
        }

        public int CheckWin() // Win checker method ================================================
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

            else if (pos[1] != "1" && pos[2] != "2" && pos[3] != "3" && pos[4] != "4" && pos[5] != "5" && pos[6] != "6" && pos[7] != "7" && pos[8] != "8" && pos[9] != "9")
            {
                return 5;
            }    
            else // No winner ----------------------------------------------
            {
                return 0;
            } 
        }
    
    }
}




