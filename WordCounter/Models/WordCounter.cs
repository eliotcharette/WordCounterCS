using System;
using System.Collections.Generic;

namespace WordCounterName
{
  public class WordCounterScore
  {
    private string _text;
    private string _word;
    private int _times;

    private static List<WordCounterScore> _instances = new List<WordCounterScore> {};

    public WordCounterScore(string word, int times)
    {
      _word = word;
      _times = times
    }

    public string GetText()
    {
      return _text;
    }
    public void FindWord()
    {
      int numberOfTimes = 0;

      Console.WriteLine("Enter a word: ");
      string userWord = Console.ReadLine();
      userWord = userWord.ToLower();
      Console.WriteLine("Your word is: " + userWord);

      Console.WriteLine("Now enter and sentence and I will tell you how many times your word occurs: ");
      string userPhrase = Console.ReadLine();
      userPhrase = userPhrase.ToLower();
      string[] separators = {",", ".", "!", "?", ";", ":", " "};
      string[] words = userPhrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);

      foreach (string word in words)
      if(word == userWord)
      {
        numberOfTimes++;
      }
      Console.WriteLine("The word you entered occurs " + numberOfTimes + " times.");
    }
  }
}
