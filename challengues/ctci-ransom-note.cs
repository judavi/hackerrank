using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
      
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        Dictionary<string,int> dic = new Dictionary<string,int>();
        
        for(int i = 0; i < n; i++){
            if(!dic.ContainsKey(ransom[i])){
                dic.Add(ransom[i], 1);
            } else {
                dic[ransom[i]] = dic[ransom[i]] +1;
            }
        }
        
        for(int i = 0; i < m; i++){
            if(dic.ContainsKey(magazine[i]) && dic[magazine[i]] > 0){
                dic[magazine[i]] = dic[magazine[i]]-1;
            } else {
                
            }
        }
        
        int result = 0;
        foreach (int val in dic.Values)
        {
            result += val;
        }
        
        if(result==0){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }
        
        
        
        
        
    }
}
