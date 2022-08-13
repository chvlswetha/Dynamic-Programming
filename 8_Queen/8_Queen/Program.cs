using System;

namespace _8_Queen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] board = { { false,false,false,false,false,false,false,false},
                                       { false,false,false,false,false,false,false,false},
                                      { false,false,false,false,false,false,false,false},
                                       { false,false,false,false,false,false,false,false},
                                        { false,false,false,false,false,false,false,false},
                                       { false,false,false,false,false,false,false,false},
                                      { false,false,false,false,false,false,false,false},
                                       { false,false,false,false,false,false,false,false}};

            bool output = NQueen( board, 8,  -1);
        }

        static bool NQueen(bool[,] board, int size, int row)
        {
            if(row == size -1)
            {
                for (int i=0; i<size;i++)
                {
                    for (int j=0; j<size; j++)
                    {
                       if (board[i, j])
                         Console.Write("Q" + ",");
                       else
                        Console.Write(" " + ",");
                    }
                    Console.WriteLine();
                }
                return true;
            }
            else
            {
                for(int col =0; col < size; col++)
                {
                    int rownew = row + 1;
                    bool valid = ValidCell(board, rownew, col, size);
                    if (valid)
                    {
                        board[rownew, col] = true;
                        if(NQueen(board, size, rownew))
                        {
                            return true;
                        }
                        board[rownew, col] = false;
                    }
                }
                return false;
            }
        }
        static bool ValidCell(bool[,] board, int rownew, int colnew, int size)
        {
            bool valid = true;
            for(int i=0; i<size; i++)
            {
                if (board[i, colnew])
                {
                    valid = false;
                }
            }
            
            for(int i = rownew, j = colnew; i>= 0 && j >= 0; i--, j--)
            {
                if (board[i, j])
                {
                    valid = false;
                }
            }
         
            for(int i = rownew, j=colnew; i>=0 && j<size; i--, j++)
            {
                if(board[i,j])
                {
                    valid = false;
                }
            }
            return valid;
        }
    }
}
