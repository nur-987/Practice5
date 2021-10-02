using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWise
{
    /// <summary>
    /// Jagged Array
    /// BitWise
    /// Out
    /// Params
    /// Shift
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            #region bitwise Operators
            //BitWise Operator
            uint a = 248;
            uint b = 28;

            uint andOperation = a & b;
            uint orOperation = a & b;
            uint xorOperation = a & b;

            Console.WriteLine("a: " + Convert.ToString(a, toBase:2 ));
            Console.WriteLine("b: " + Convert.ToString(a, toBase: 2));
            Console.WriteLine("Result: " + Convert.ToString(andOperation, toBase: 2));
            Console.WriteLine("Result: " + Convert.ToString(orOperation, toBase: 2));
            Console.WriteLine("Result: " + Convert.ToString(xorOperation, toBase: 2));


            //Shift Operator
            //Shift the binary numb to the based on the num after (<<)
            //based on the direction of (<<) (>>)
            //add zeros at the back

            uint c = 10;
            uint leftshift = c << 2; //after shifting the numb = 40
            Console.WriteLine(Convert.ToString(c, toBase: 2));
            Console.WriteLine(Convert.ToString(leftshift, toBase:2));

            uint d = 40;
            uint rightshift = d >> 3;

            //unity operators. only one operant 
            //binary has 2 operant


            //Complement operators
            a = 10;
            b = 20;
            c = 30;
            d= 40;

            var res = ~ d | b ^ a & c;
            #endregion

            //Jagged Arrays
            jagged_Array();

            ResultCheck(out int res1, 1, 6);

        }

        private static void jagged_Array()
        {
            int[][] myArray = new int[4][];
            myArray[0] = new int[2] { 8, 2 };//number of columns in the row (2)
            myArray[2] = new int[] { 19,34,22};// dnt assign the size => auto 
            myArray[3] = new int[4] { 1, 3, 12, 7 };
            myArray[4] = new int[1] { 4 };

            //METHOD 2
            int[][] myArry2 = new int[][]
            {
                new int[]{1,5,2},
                new int[]{0,8,3,6}
            };

            for(int i = 0; i<myArray.Length; i++)
            {
                for(int j = 0; j<myArray[i].Length; j++)
                {
                    Console.WriteLine($"Jagged Array element{i} {j} is {myArray[i][j]}");
                }
            }
        }

        private static void ref_out_param()
        {

            int a = 10;
            int b = 20;

            Console.WriteLine(a); //10
            Console.WriteLine(b); //20

            swap(a, b);
            Console.WriteLine(a); //10
            Console.WriteLine(b); //20
            //Didnt change

            swapbyRef(ref a, ref b);
            Console.WriteLine(a); //20
            Console.WriteLine(b); //10
            //swap succesfull out in the main


        }
        private static void swap(int a, int b)
        {

            int temp = a;
            a = b;
            b = temp;
            //a:20 b:10
        }
        private static void swapbyRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;


        }
        private static void out_param_Modifier()
        {
            object obj = 25;
            int res;
            isValidint(obj, out res);
        }

        private static void param_methd()
        {
            //method 1
            PrintParam(1, 2, 5, 3, 7, 8, 3, 5);

            //method 2
            int[] myArr = new int[] { 3,21, 8, 2, 6, 1 };
            PrintParam(4, myArr);
        }
        private static void PrintParam(int a, params int[] list)
        {
            for(int i = 0; i<list.Length; i++)
            {
                Console.WriteLine($"List element {i} is {list[i]}");
            }
        }

        private static bool isValidint(object s, out int res)
                        //without (res) would only return True or False
                        //how to send the value back? 
                        //use (out) to push out the value back
        {
            if (s is int)
            {
                res = (int)s;
                return true;
            }
            res = -1;
            return false;
        }

        public static bool ResultCheck(out int res1, params int[] a)
        {
            int c = a[0] - a[1];
            if (c < 0)
            {
                res1 = c;
                return false;
            }
            else
            {
                res1 = c;
                return true;
            }
        }

    }
}
