using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        
        //Iterate over first array
        for(int i = 0; i < a.Length; i++)
        {
            if (dictionary.ContainsKey(a[i])) {
                dictionary[a[i]] = dictionary[a[i]] + 1;
            }
            else {
                dictionary.Add(a[i],1);
            }
        }
        
        //Iterate over the second to remove letters
        //and is is not present count
        int counter = 0;
        for(int i = 0; i < b.Length; i++)
        {
            if (dictionary.ContainsKey(b[i])) {
                dictionary[b[i]] = dictionary[b[i]] - 1;
            }
            else {
                counter += 1;
            }
        }
        
        Console.WriteLine(dictionary.Sum(x => Math.Abs(x.Value))+counter);
        
        
    }
}
