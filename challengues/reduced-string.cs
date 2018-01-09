using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
    
    static string super_reduced_string(String s) {
        int size = s.Length;
        Char[] array = s.ToCharArray();
        Stack<Char> stack = new Stack<Char>();
        for(int i = 0; i < size; i++){
            if(stack.Count == 0){
                stack.Push(array[i]);
            } else if(array[i] != stack.Peek()) {
                stack.Push(array[i]);
            }
            else {
                stack.Pop();
            }
        }
        if(stack.Count != 0)
            return new string(stack.Reverse().ToArray());
        else
            return "Empty String";
    }
    
    
}
