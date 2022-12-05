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
        double n = arr.Count;
        double plus = 0, minus = 0, zeros = 0;
        foreach (var i in arr)
        {
            if (i > 0)
                plus++;
            if (i < 0)
                minus++;
            if (i == 0)
                zeros++;
        }
        string nplus = (plus / n).ToString("0.000000");
        string nminus = (minus / n).ToString("0.000000");
        string nzeros = (zeros / n).ToString("0.000000"); ;
        System.Console.WriteLine("{0} ", nplus);
        System.Console.WriteLine("{0} ", nminus);
        System.Console.WriteLine("{0} ", nzeros);
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
