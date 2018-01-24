//https://www.hackerrank.com/challenges/migratory-birds/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        foreach(int bird in ar){
           if(count.ContainsKey(bird)){
               count[bird] = count[bird] + 1;
           } else{
               count.Add(bird,1);
           }
        }
        
        int max = count.Values.Max();
        return count.Where(x => x.Value == max).OrderBy(x => x.Key).FirstOrDefault().Key;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
