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

class Solution {

    // Complete the luckBalance function below.
    static int luckBalance(int k, int[][] contests, int n) {
        int luck = 0;
        int count = 1;
        Console.WriteLine("n" + n);
        List<int> important = new List<int>();
         for(int i = 0; i < n ; i ++) {
            if(contests[i][1] == 0){
                luck = luck + contests[i][0];
            } else  {
                important.Add(contests[i][0]);
            }
        }
        
        important.Sort();
        important.Reverse();
        for(int i = 0; i < important.Count; i ++){
            Console.WriteLine(count);
            if(count <= k){
                luck = luck + important[i];
                count = count + 1;
            } else {
                luck = luck - important[i];
            }
        }
        return luck;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[][] contests = new int[n][];

        for (int i = 0; i < n; i++) {
            contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        }

        int result = luckBalance(k, contests, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
