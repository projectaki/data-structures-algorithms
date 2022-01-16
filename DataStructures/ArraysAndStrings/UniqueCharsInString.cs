namespace ArraysAndStrings {
    public static class UniqueCharsInString {
        public static bool isUniqueChar(string word, int alphabetLength) {
            if(word.Length > alphabetLength) return false;

            int shiftBy = (int)"a"[0];
            bool[] hashSet = new bool[alphabetLength];

            for (int i = 0; i < word.Length; i++)
            {
                int letterIndex = (int)word[i] - shiftBy;
                if(hashSet[letterIndex] == true) return false;
                hashSet[letterIndex] = true;
            }
            return true;
        }
    }
}
