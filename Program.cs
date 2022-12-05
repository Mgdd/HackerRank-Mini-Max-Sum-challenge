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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     
     Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Example
arr=[1,3,5,7,9]
The minimum sum is 1+3+5+7=16 and the maximum sum is 3+5+7+9=24. The function prints
16 24

     */

    public static void miniMaxSum(List<int> arr)
    {
        long min = arr[0], max = arr[0];
        long summin = 0,summax = 0;
        int ifequal = 1;
        int arrTest=arr[0];
        for(int i=0;i<arr.Count;i++)
        {
            if (arr[i] != arrTest)
                ifequal = 0;
        }
        foreach (var i in arr)
        {
            if (i <= min)
                min = i;
            if (i >= max)
                max = i;
        }
        foreach (var y in arr)
        {
            if (y != min||ifequal==1)
                summax += y;
            if (y != max || ifequal == 1)
                summin += y;
        }
        if (ifequal == 1)
        {
            summax -= arr[0];
            summin -= arr[0];
        }
        System.Console.WriteLine("{0} {1} ", summin,summax);
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
