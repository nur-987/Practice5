using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{/// <summary>
/// jagged Array.
/// A 2D array in a jagged array
/// trying to access the numbers.
/// Currently "rank" not able to acces beyond 2 array
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            int[][,] jaggedArry = new int[2][,]
            {
                new int[,] {{1,3},{2,7}},
                new int[,] {{2,4}, {4,6}, { 0, 4 } }
            };
            for(int i =0; i< jaggedArry.Length; i++)
            {
                int x = 0;
                for (int j = 0; j< jaggedArry[i].GetLength(x); j++)
                {
                    for (int k=0; k< jaggedArry[j].Rank; k++)
                    {
                        Console.WriteLine($"eLEMENTS {i} {j} is {jaggedArry[i][j,k]}");
                    }
                }
            }
            Console.ReadLine();
        }

    }
}
