using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */


    public static void plusMinus(List<int> arr)
    {
        double negative = 0;
        double zero = 0;
        double positive = 0;
        double negFraction;
        double zeroFraction;
        double posFraction;
        if (arr.Count > 0 && arr.Count <= 100)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] >= -100 && arr[i] <= 100)
                {
                    if (arr[i] >= -100 && arr[i] < 0)
                    {
                        negative++;
                    }
                    else if (arr[i] == 0)
                    {
                        zero++;
                    }
                    else positive++;
                }
                else continue;
            }
        }
        negFraction = negative / arr.Count();
        zeroFraction = zero / arr.Count();
        posFraction = positive / arr.Count();
        Console.WriteLine(negFraction);
        Console.WriteLine(zeroFraction);
        Console.WriteLine(posFraction);
        Console.WriteLine(arr.Count());
        
        Console.WriteLine(negFraction.ToString("F4"));
        Console.WriteLine(posFraction.ToString("F4"));
        Console.WriteLine(zeroFraction.ToString("F4"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
