using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Board
    {
        public int[,] Data { get; protected set; }

        public Board()
        {
            Data = new int[4, 4];
        }

        public void Create_Board() // TO DO
        {
        }

        public int[,] Create_Start_Board()
        {
            int[] options = { 2, 4 };
            Random r = new Random();
            for (int i = 0; i < 2; i++)
            {
                int random_index = r.Next(0, 2);
                int value = options[random_index];
                int row = r.Next(0, 4);
                int col = r.Next(0, 4);
                Data[row, col] = value;
            }
            Data[0, 0] = 2;
            Data[0, 1] = 2;
            Data[0, 2] = 2;
            Data[0, 3] = 2;
            return Data;
        }

        public int[,] Move(Direction move_direction)
        {
            string direction = "";
            int[,] changes = new int[4, 4];
            if (move_direction == Direction.left || move_direction == Direction.right)
            {
                if(move_direction == Direction.left)
                {
                    direction = "left";
                }
                else if(move_direction == Direction.right)
                {
                    direction = "right";
                }
                    changes = Calculate_cols();
                //Data = Reset_Board(changes, direction);
            }
            if (move_direction == Direction.up || move_direction == Direction.down)
            {
                if (move_direction == Direction.up)
                {
                    direction = "up";
                }
                else if (move_direction == Direction.down)
                {
                    direction = "down";
                }
                changes = Calculate_rows();
                //Reset_Board(changes, direction);
            }
            return changes;
        }
        private int[,] Calculate_rows()
        {
            int[,] changes = new int[4, 4];
            int currnt_sum = Data[0, 0];
            int sum = currnt_sum;
            int[,] currnt_chack = Data;
            int was_connection = 0;
            for (int i = 0; i < 4; i++)
            {
                was_connection = 0;
                currnt_sum = Data[0, i];
                sum = currnt_sum;
                for (int j = 0; j < 4; j++)
                {
                    was_connection = 0;
                    if (currnt_sum > sum)
                    {
                        j++;
                        if (j == 4)
                        {
                            break;
                        }
                        currnt_sum = Data[j, i];
                        sum = currnt_sum;
                    }
                    while (((j + 1 < 3) && currnt_chack[j+1, i] == 0))
                    {
                        j++;
                    }
                    if (j == 2 && currnt_chack[j + 1, i] == 0)
                    {
                        break;
                    }
                    if (j != 3)
                    {
                        if (currnt_chack[j, i] == currnt_chack[j+1, i])
                        {
                            if (currnt_chack[j, i] != 0)
                            {
                                currnt_sum += currnt_chack[j + 1, i];
                                was_connection += 1;
                            }
                            else
                            {
                                currnt_sum = currnt_chack[j, i] + currnt_chack[j+1, i];
                                was_connection += 1;
                            }
                        }
                    }
                    if (changes[j, i] == 0 && was_connection == 1)
                    {
                        if (j != 0)
                        {
                            changes[j - 1, i] = currnt_sum;
                        }
                        else
                        {
                            changes[j, i] = currnt_sum;
                        }
                    }
                }
            }
            return changes;
        }
        private int[,] Calculate_cols()
        {
            int[,] changes = new int[4,4];
            int currnt_sum = Data[0, 0];
            int sum = currnt_sum;
            int[,] currnt_chack = Data;
            int was_connection = 0;
            for (int i = 0; i < 4; i++)
            {
                was_connection = 0;
                currnt_sum = Data[i, 0];
                sum = currnt_sum;
                for (int j = 0; j < 4; j++)
                {
                    was_connection = 0;
                    if (currnt_sum > sum)
                    {
                        j++;
                        if (j == 4)
                        {
                            break;
                        }
                        currnt_sum = Data[i, j];
                        sum = currnt_sum;
                    }
                    while(((j+1 < 3) && currnt_chack[i, j + 1] == 0))
                    {
                        j++;
                    }
                    if(j == 2 && currnt_chack[i, j + 1] == 0)
                    {
                        break;
                    }
                    if(j != 3)
                    {
                        if (currnt_chack[i, j] == currnt_chack[i, j + 1])
                        {
                            if (currnt_chack[i, j] != 0)
                            {
                                currnt_sum += currnt_chack[i, j + 1];
                                was_connection += 1;
                            }
                            else
                            {
                                currnt_sum = currnt_chack[i, j] + currnt_chack[i, j + 1];
                                was_connection += 1;
                            }
                        }
                    }
                    if(changes[i, 0] == 0 && was_connection == 1)
                    {
                        if (i == 0)
                        {
                            changes[0, 0] = currnt_sum;
                        }
                        else
                        {
                            changes[i , 0] = currnt_sum;
                        }
                    }
                    else if(was_connection == 1)
                    {
                        changes[i, 1] = currnt_sum;
                    }
                }
            }
            return changes;
        }
        public int[,] Reset_Board(int[,] changes, string direction)
        {
            int[,] move_changes = Data;
            if (direction == "right" || direction == "left")
            {
                move_changes = Move_Cols(changes, direction);
            }
            return move_changes;
            //if (direction == "up" || direction == "down")
            //{
            //    Move_Rows(changes, direction);
            //}
        }
        private int[,] Move_Cols(int[,] changes, string direction)
        {
            int[,] currnt_data = Data;
            if (direction == "right")
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if(changes[i,j] > 0 && changes[i, j + 1] > 0)
                        {
                            if(changes[i,j] == changes[i, j + 1])
                            {
                                int currnt = changes[i, j];
                                if(currnt > Data[i,0] && currnt > Data[i, 1] && currnt > Data[i, 2] && currnt > Data[i, 3])
                                {
                                    currnt_data[i, 3] = currnt;
                                }
                                if(currnt_data[i,j] > currnt_data[i, j + 1])
                                {
                                    int replace = currnt_data[i, j];
                                    currnt_data[i, j] = currnt_data[i, j + 1];
                                    currnt_data[i, j + 1] = replace;
                                }
                            }
                        }
                    }
                }
                return currnt_data;
            }
            return currnt_data;
        }
    }
}
