namespace ArraysAndStrings {
    public static class StringRotation {
        
        public static bool IsStringRotation(string one, string two) {
            return (one + one).Contains(two);
        }
    }
}
