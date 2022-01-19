namespace ArraysAndStrings {
    public static class Permutation {
        /*
         Permutation in this excersize means that we have the same characters in both words
         and the character counts are also exactly the same.

        We can first check if the two strings are of the same length. If they are not then we dont have
        a permutation.

        Time complexity, we need to loop through both of the strings at least once.

        Then we create an integer array, loop through the first string and store the count in the
        array at char at ascii code.

        Then we loop through the second word, and we decrease the count by one at char ascii, if it is ever smaller
        than 0, we can return false;
        
         */
        public static bool isPermutation(string word, string compareTo, int alphabetLength) {
            if(word.Length != compareTo.Length) return false;

            int[] hashmap = new int[alphabetLength];

            foreach (var c in word)
            {
                var arrIdx = getArrayIndex(c);
                hashmap[arrIdx]++;
            }
            foreach (var c in compareTo)
            {
                var arrIdx = getArrayIndex(c);
                if(hashmap[arrIdx] == 0) return false;
                hashmap[arrIdx]--;
            }
            return true;
        }

        private static int getArrayIndex(char c) {
            int shiftBy = (int)"a"[0];
            return (int)c - shiftBy;
        }
    }
}