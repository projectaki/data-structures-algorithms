namespace ArraysAndStrings {
    public static class Urlify {
        
        /*
            "Mr John Smith    "; 13

            Start going from the back, and keep track of two indexes,
            the search index and insert index;
        */
        public static string StringToUrl(string sentence) {
            int insertIndex = sentence.Length - 1;
            var charArray = sentence.ToCharArray();
            bool evalSpaces = false;

            for (int i = sentence.Length - 1; i >= 0;i--) {
                if(sentence[i] != " "[0]) {
                    charArray[insertIndex--] = sentence[i];
                    if(!evalSpaces) evalSpaces = true;
                }
                else {
                    if(evalSpaces) {
                        charArray[insertIndex--] = "0"[0];
                        charArray[insertIndex--] = "2"[0];
                        charArray[insertIndex--] = "%"[0];
                    }
                }
            }
            return new string(charArray);
        }
    }
}
