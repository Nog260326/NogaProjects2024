using System;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            int[,] board = b.Create_Start_Board();
            //Console.WriteLine(board[1, 1]);
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the directin you want to move: ");
            string moving_direction = Console.ReadLine();
            int[,] currnt = new int[4, 4]; 
            if(moving_direction == "right")
            {
                currnt = b.Move(Direction.right);
            }
            else if (moving_direction == "left")
            {
                currnt = b.Move(Direction.left);
            }
            else if (moving_direction == "up")
            {
                currnt = b.Move(Direction.up);
            }
            else if (moving_direction == "down")
            {
                currnt = b.Move(Direction.down);
            }
            for (int i = 0; i < currnt.GetLength(0); i++)
            {
                for (int j = 0; j < currnt.GetLength(1); j++)
                {
                    Console.Write(currnt[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] print = b.Reset_Board(currnt, "right");
            for (int i = 0; i < print.GetLength(0); i++)
            {
                for (int j = 0; j < print.GetLength(1); j++)
                {
                    Console.Write(print[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    
}
