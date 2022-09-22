using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> board = createBoard();
           displayBoard(board);
           string isWinner = "no";

           while (isWinner == "no")
           {
                if (isWinner == "no")
                {
                    xTurn(board);
                    displayBoard(board);
                    isWinner = checkWinner(board, isWinner);
                }
                if (isWinner == "no")
                {
                    oTurn(board);
                    displayBoard(board);
                    isWinner = checkWinner(board, isWinner);
                }
                
           } 
           
        }

        static List<string> createBoard()
        {
            List<string> board = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            return board;
        }

        static void displayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        static void xTurn(List<string> board)
        {
            Console.Write("x's turn to choose a square (1-9): ");
            string userInput = Console.ReadLine();
            int inputNumber = int.Parse(userInput);
            int index = inputNumber - 1;

            string insert = "yes";
            while(insert == "yes")
            {
                if (board[index] == "x" || board[index] == "o")
                {
                    Console.WriteLine("You have chose an invalid square.");
                    Console.Write("Please choose an unoccupied square: ");

                    userInput = Console.ReadLine();
                    inputNumber = int.Parse(userInput);
                    index = inputNumber - 1;
                }
                else
                {
                    insert = "no";
                    board[index] = "x";
                }
            }
        }

        static void oTurn(List<string> board)
        {
            Console.Write("o's turn to choose a square (1-9): ");
            string userInput = Console.ReadLine();
            int inputNumber = int.Parse(userInput);
            int index = inputNumber -1;
            
            string insert = "yes";
            while(insert == "yes")
            {
                if (board[index] == "x" || board[index] == "o")
                {
                    Console.WriteLine("You have chose an invalid square.");
                    Console.Write("Please choose an unoccupied square: ");

                    userInput = Console.ReadLine();
                    inputNumber = int.Parse(userInput);
                    index = inputNumber - 1;
                }
                else
                {
                    insert = "no";
                    board[index] = "o";
                }
            }
        }

        static string checkWinner(List<string> board, string isWinner)
        {
            // x is the winner
            if (board[0] == "x" && board[1] == "x" && board[2] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";
            }
            else if (board[3] == "x" && board[4] == "x" && board[5] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[6] == "x" && board[7] == "x" && board[8] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[0] == "x" && board[3] == "x" && board[6] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[1] == "x" && board[4] == "x" && board[7] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[2] == "x" && board[5] == "x" && board[8] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[0] == "x" && board[4] == "x" && board[8] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[2] == "x" && board[4] == "x" && board[7] == "x")
            {
                Console.WriteLine("x is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }

            // o is the winner
            else if (board[0] == "o" && board[1] == "o" && board[2] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";
            }
            else if (board[3] == "o" && board[4] == "o" && board[5] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[6] == "o" && board[7] == "o" && board[8] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[0] == "o" && board[3] == "o" && board[6] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[1] == "o" && board[4] == "o" && board[7] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[2] == "o" && board[5] == "o" && board[8] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[0] == "o" && board[4] == "o" && board[8] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            else if (board[2] == "o" && board[4] == "o" && board[7] == "o")
            {
                Console.WriteLine("o is the winner! Good game! Thanks for playing.\n");
                isWinner = "yes";   
            }
            
            // draw
            else if (board[0] != "1" && board[1] != "2" && board[2] != "3" && board[3] != "4" && board[4] != "5" &&
            board[5] != "6" && board[6] != "7" && board[7] != "8" && board[8] != "9")
            {
                Console.WriteLine("It is a draw. Thanks for playing.\n");
                isWinner = "yes";
            }

            // no winner yet
            else
            {
                isWinner = "no";
            }

            return isWinner;
        }

    }
}