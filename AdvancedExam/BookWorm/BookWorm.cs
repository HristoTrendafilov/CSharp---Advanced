using System;
using System.Collections.Generic;
using System.Linq;
namespace BookWorm
{
    class BookWorm
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];

            var row = 0;
            var col = 0;

            for (int i = 0; i < n; i++)
            {
                var rowToAdd = Console.ReadLine();
                
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowToAdd[j];
                    if (rowToAdd[j] == 'P')
                    {
                        row = i;
                        col = j;
                    }
                }
            }
            
            while (true)
            {
                var command = Console.ReadLine();
                
                if (command == "end")
                {
                    break;
                }
                else if (command == "up")
                {
                    if (row == 0)
                    {
                        if (str.Length > 0)
                        {
                            str = str.Remove(str.Length - 1);
                        }
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        
                        if (char.IsLetter(matrix[row - 1, col]))
                        {
                            str += matrix[row - 1, col];
                            matrix[row - 1, col] = 'P';
                            row = row - 1;
                        }
                        else
                        {
                            matrix[row - 1, col] = 'P';
                            row = row - 1;
                        }
                    }
                }
                else if (command == "down")
                {
                    if (row == n-1)
                    {
                        if (str.Length > 0)
                        {
                            str = str.Remove(str.Length - 1);
                        }
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        if (char.IsLetter(matrix[row +1 , col]))
                        {
                            str += matrix[row + 1, col];
                            matrix[row + 1, col] = 'P';
                            row = row + 1;
                        }
                        else
                        {
                            matrix[row + 1, col] = 'P';
                            row = row + 1;
                        }
                    }
                }
                else if (command == "right")
                {
                    if (col == n-1)
                    {
                        if (str.Length > 0)
                        {
                            str = str.Remove(str.Length - 1);
                        }
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        if (char.IsLetter(matrix[row, col+1]))
                        {
                            str += matrix[row , col+1];
                            matrix[row , col+1] = 'P';
                            col = col + 1;
                        }
                        else
                        {
                            matrix[row , col+1] = 'P';
                            col = col + 1;
                        }
                    }
                }
                else if (command == "left")
                {
                    if (col == 0)
                    {
                        if (str.Length > 0)
                        {
                            str = str.Remove(str.Length - 1);
                        }
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        if (char.IsLetter(matrix[row, col - 1]))
                        {
                            str += matrix[row, col - 1];
                            matrix[row, col - 1] = 'P';
                            col = col - 1;
                        }
                        else
                        {
                            matrix[row, col - 1] = 'P';
                            col = col - 1;
                        }
                    }
                }
            }
            if (str.Length > 0)
            {
                Console.WriteLine(str);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
