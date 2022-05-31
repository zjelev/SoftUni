using System;
using System.Linq;

namespace MultidimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Sum Matrix Elements 
            /*
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                    //.Split(", ")  // 1. Sum Matrix Elements 
                    .Split(" ")     //2. Sum Matrix Columns
                    .Select(int.Parse)
                    .ToArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sum = 0;

            
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            

            foreach (var item in matrix)
            {
                sum += item;    
            }
            Console.WriteLine(sum);
            */

            //2. Sum Matrix Columns
            /*
            for (int col = 0; col < size[1]; col++)
            {
                for (int row = 0; row < size[0]; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            */

            //3.Primary Diagonal
            /*
            int size = int.Parse(Console.ReadLine());
            int [,] matrix = new int[size, size];
            
            for (int row = 0; row < size; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
            */

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            
            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] =  currentRow[col];
                }
            }
            var symbol = Console.ReadLine();
            bool found = false;
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == char.Parse(symbol))
                    {
                        found = true;
                        Console.WriteLine($"({row}, {col})");
                    }
                }
            }

            if (found == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}