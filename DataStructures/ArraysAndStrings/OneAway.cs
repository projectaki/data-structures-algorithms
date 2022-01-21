using System;

namespace ArraysAndStrings {
    public static class OneAway {
        /*
         Palindrome rules:
         exactly one character can optionaly have an odd count, and the rest have to have an even count.

        
         */
        public static bool isOneAway(string word,string compareTo) {
            if(Math.Abs(word.Length - compareTo.Length) > 1) return false;

            var shorter = word.Length < compareTo.Length ? word : compareTo;
            var longer = word.Length < compareTo.Length ? compareTo : word;
        
            var wordIdx = 0;
            var compIdx = 0;
            bool found = false;
            while(wordIdx < shorter.Length) {
                if(shorter[wordIdx] != longer[compIdx]) {
                    compIdx++;
                    if(word.Length == compareTo.Length) wordIdx++;
                    if(found) return false;
                    found = true;
                }
                else {
                    wordIdx++;
                    compIdx++;
                }
            }  
            return true;      
        }
    }
}