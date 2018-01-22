using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        var position = new Dictionary<int,int>();
        var stack = new Stack<int>();
        int pos = 1;
        foreach(int score in scores){
            if (!position.ContainsKey(score))
            {
                position.Add(score, pos);
                stack.Push(score);
                pos += 1;
            }
        }
        
        
        int index = stack.Peek();
        
        foreach(int score in alice){
            if(index == score){
               Console.WriteLine(position[index]);
            } else if (index > score){
                Console.WriteLine(position[index]+1);
            } else {
                while (stack.Count > 0 && index < score)
                {
                    index = stack.Pop();
                    if(index > score){
                        Console.WriteLine(position[index]+1);
                    } else if(index == score){
                        Console.WriteLine(position[index]);
                    }
                }
                if(score > index){
                    Console.WriteLine(1);
                }
            }

        }
        
       
        return scores;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores_temp = Console.ReadLine().Split(' ');
        int[] scores = Array.ConvertAll(scores_temp,Int32.Parse);
        int m = Convert.ToInt32(Console.ReadLine());
        string[] alice_temp = Console.ReadLine().Split(' ');
        int[] alice = Array.ConvertAll(alice_temp,Int32.Parse);
        int[] result = climbingLeaderboard(scores, alice);
        //Console.WriteLine(String.Join("\n", result));


    }
}
