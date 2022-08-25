namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence)
           => sentence.ToLower().Contains("english");
    }
}