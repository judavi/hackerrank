using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        //Iterate over first array
        for(int i = 0; i < a.Length; i++)
        {
            if (dictionary.ContainsKey(a[i].ToString())) {
                dictionary[a[i].ToString()] = dictionary[a[i].ToString()] +1;
            }
            else {
                dictionary.Add(a[i].ToString(),1);
            }
        }
        
        //Iterate over the second to remove letters
        for(int i = 0; i < b.Length; i++)
        {
            if (dictionary.ContainsKey(b[i].ToString())) {
                dictionary[b[i].ToString()] = dictionary[b[i].ToString()] - 1;
            }
            else {
                dictionary.Add(b[i].ToString(),1);
            }
        }
        
        Console.WriteLine(dictionary.Sum(x => Math.Abs(x.Value)));
        
        
    }
}
