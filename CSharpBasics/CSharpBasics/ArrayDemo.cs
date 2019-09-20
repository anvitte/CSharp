using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    //class ArrayDemo
    //{
    //    enum columnDef { Column0 = 2, Column1 = 5, Column2 = 1 };

    //    static void Main(string[] args)
    //    {
    //        //Invalid - must have to add 5 elemnt if size set to 5
    //        // int[] array1 = new int[5]{1,2,3,4 };

    //        //Valid Declaration
    //        int[] array = { 1, 2, 3, 4, 5, 6 };

    //        //Implicit Type
    //        var names = new[] { "ankit", "Ankit TYgai" };

    //        //Passing array in a method
    //        int?[] data;
    //        //PrintArray(data);
    //        int[] array3 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    //        data = array3.Cast<int?>().ToArray();
    //        PrintArray(data);

    //        //Copying Array
    //        //Case 1
    //        int[] array4 = new int[4] { 1, 2, 3, 4 };
    //        int[] array5 = array4;
    //        Console.WriteLine("Array 4 display element");
    //        foreach (var item in array4)
    //        {
    //            Console.Write($"{ item }, ");

    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("Array 5 display element");
    //        foreach (var item in array5)
    //        {
    //            Console.Write($"{ item }, ");

    //        }
    //        Console.WriteLine("Change in array4 4th position");
    //        array4[3] = 5;
    //        Console.WriteLine("Array 4 display element");
    //        foreach (var item in array4)
    //        {
    //            Console.Write($"{ item }, ");

    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("Array 5 display element");
    //        foreach (var item in array5)
    //        {
    //            Console.Write($"{ item }, ");

    //        }
    //        //case 2 copy array

    //        Console.WriteLine("Case 2 copy array");
    //        int[] array6 = new int[5] { 1, 2, 3, 4, 5 };
    //        int[] array7 = new int[array6.Length];
    //        array6.CopyTo(array7, 0);
    //        foreach (var item in array7)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();
    //        array6[4] = 10;
    //        Console.WriteLine("Change item in array 6");
    //        foreach (var item in array6)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("Change item in array 7");
    //        foreach (var item in array7)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        //Case 3 - Cloning

    //        int[] array8 = new int[] { 1, 2, 3, 4, 5 };
    //        int[] array9 = (int[])array8.Clone();
    //        Console.WriteLine("Data After cloning");
    //        foreach (var item in array9)
    //        {
    //            Console.WriteLine(item + " ");
    //        }
    //        array8[4] = 10;
    //        Console.WriteLine("Change item in array 8");
    //        foreach (var item in array8)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("Change item in array 9");
    //        foreach (var item in array9)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();


    //        // Jagged Array
    //        int[][] array10 = new int[3][];


    //        //Defining column and assigning column values for above 3 rows
    //        int[] column0 = new int[(int)columnDef.Column0] { 110, 120 };

    //        int[] column1 = new int[(int)columnDef.Column1] { 1, 2, 3, 4, 5 };

    //        int[] column2 = new int[(int)columnDef.Column2] { 201 };

    //        array10[0] = column0;
    //        array10[1] = column1;
    //        array10[2] = column2;

    //        //Display Jagged array
    //        for (int i = 0; i < array10.Length; i++)
    //        {

    //            int columnLength = array10[i].Length;
    //            for (int j = 0; j < columnLength; j++)
    //            {
    //                Console.Write(array10[i][j] + " ");
    //            }
    //            Console.WriteLine();

    //        }
    //        // Param Arrays

    //        int[] array11 = new int[2] { 10, 20 };

    //        int[] array12 = new int[5] { 10, 20, 30, 40, 50 };

    //        //When we dont know how much paramter we have to pass in the method

    //        ParamArray(10, 12);
    //        ParamArray(10, 12, 15, 16, 18, 19);
    //        ParamArray(array12);
    //        Console.ReadKey();


    //    }
    //    static void PrintArray(int?[] data)
    //    {
    //        if (data != null)
    //        {
    //            foreach (var item in data)
    //            {
    //                Console.WriteLine(item); ;
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("No data found");
    //        }

    //    }

    //    static void ParamArray(params int[] paramList)
    //    {
    //        foreach (var item in paramList)
    //        {
    //            Console.Write(item+" "); 
    //        }
    //        Console.WriteLine();
    //    }
    //}
}
