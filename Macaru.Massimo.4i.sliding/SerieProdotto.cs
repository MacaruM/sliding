using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if(span == 0)
        {
            return 1;
        }
        if (digits.Length - span <0 || span<0)
        {
        throw new ArgumentException();
        }
        int max = 0;
     for (int i = 0; i <= digits.Length - span; i++)
     {
        int prod = 1;
        for (int j = 0; j < span; j++)
        {
            prod *= int.Parse(digits.Substring(i + j, 1));
        }
        if (prod > max)
        {
            max = prod;
        }
     }
     return max;
     
     
    }
}