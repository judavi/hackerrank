//https://www.hackerrank.com/challenges/birthday-cake-candles/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for(int i = 0; i < n; i ++){
            if(dictionary.ContainsKey(ar[i])){
                dictionary[ar[i]] = dictionary[ar[i]] + 1;
            }
            else {
                dictionary.Add(ar[i],1);
            }
        }
        
        return dictionary.Values.Max();
        
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
