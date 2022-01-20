namespace ArraysAndStrings {
    public static class PalindromePermutation {
        /*
         Palindrome rules:
         exactly one character can optionaly have an odd count, and the rest have to have an even count.

        
         */
        public static bool isPalindromePermutation(string word, int alphabetLength) {

            bool[] hashmap = new bool[alphabetLength];
            int oddCount = 0;

            foreach (char c in word)
            {
                var arrIdx = getArrayIndex(c);
                hashmap[arrIdx] = !hashmap[arrIdx];
                if(hashmap[arrIdx]) oddCount++;
                else oddCount--;
            }
            return oddCount == 1 || oddCount == 0;
        }

        private static int getArrayIndex(char c) {
            int shiftBy = (int)"a"[0];
            return (int)c - shiftBy;
        }
    }
}