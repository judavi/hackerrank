using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    //using two stack like passing water between two glasses
        
    static void Main(String[] args) {
        Stack<int> one = new Stack<int>();
        Stack<int> two = new Stack<int>();
        int operations = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < operations; i++){
          String[] o = Console.ReadLine().Split(' ');
          int operation = Convert.ToInt32(o[0]);
          if(operation==1){
              one.Push(Convert.ToInt32(o[1]));
          } else if(operation==2){
              if(two.Count == 0){
                  while(one.Count > 0){
                      two.Push(one.Pop()); 
                  }
                  two.Pop();
              } else {
                  two.Pop();
              }
          } else if(operation==3){
            if(two.Count == 0){
                while(one.Count > 0){
                      two.Push(one.Pop()); 
                }
            }
            Console.WriteLine(two.Peek());  
            
          }
            
        }
        
    }
    
    
    
}
