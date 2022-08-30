using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Robot
{
    private List<string> _learnedWords = new(){"i", "do", "not", "understand", "the", "input", "already", "know", "word", "thank", "you", "for", "teaching", "me"};
    public string LearnWord(string word)
    {
        Console.WriteLine(word);
        var wordLc = word.ToLower();
        if(!new Regex(@"^[a-zA-Z]+$").IsMatch(wordLc))
            return "I do not understand the input";

        if(_learnedWords.Contains(wordLc))
            return $"I already know the word {word}";

        _learnedWords.Add(wordLc);
        return $"Thank you for teaching me {word}";
    }
}