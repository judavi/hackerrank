using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
    
        for(int a0 = 0; a0 < t; a0++){
            validate(Console.ReadLine());
        }
    }

        
    static void validate(String expression){
        Char[] symbols = expression.ToCharArray();
        Stack<Char> stack = new Stack<Char>();
        bool wellFormed = true;
        foreach(Char symbol in symbols){
            if(symbol =='{' || symbol =='[' || symbol == '('){
                stack.Push(symbol);
            } else {
                if(stack.Any()){
                    if(stack.Peek() == '{'&& symbol == '}'){
                        stack.Pop();
                    } else if(stack.Peek() == '[' && symbol == ']'){
                        stack.Pop();
                    } else if(stack.Peek() == '(' && symbol == ')'){
                        stack.Pop();
                    } else {
                        wellFormed = false;
                        break;
                    }
                } else {
                    
                }
            }
        }
                
        if(wellFormed && stack.Count == 0){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }        
        
    
}
