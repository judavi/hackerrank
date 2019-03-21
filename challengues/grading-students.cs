using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        List<int> result = new List<int>();
        foreach(int g in grades){
            if(g < 38){
                result.Add(g);
                continue;
            } else if(g % 5 >= 3) {
                result.Add(g + (5 - g % 5));
                continue;
            } else {
                result.Add(g);
                continue;
            }
        }
        return result.ToArray();
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
