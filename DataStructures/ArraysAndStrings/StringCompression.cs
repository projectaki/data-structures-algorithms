using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings {
    public static class StringCompression {
        
       /*
        Time complexity: O(string length)
        
       */
       public static string CompressString(string str) {
           char prevChar = str[0];
           int streak = 1;
           StringBuilder sb = new StringBuilder();

           for (int i = 1; i < str.Length; i++)
           {
               if(str[i] == prevChar) {
                   streak++;
               }
               else {
                   AddToString(prevChar, streak, sb);
                   streak = 1;
                   prevChar = str[i];
               }
               if (i == str.Length - 1) {
                    AddToString(prevChar, streak, sb);
               }
           }

           return sb.ToString().Length < str.Length ? sb.ToString() : str;
       }

        private static void AddToString(char c, int count, StringBuilder sb) {
            sb.Append(c);
            sb.Append(count);
        }
       
    }
}
