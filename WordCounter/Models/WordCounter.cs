using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounterName
{
  public class WordCounterScore
  {
    private string _text;
    private string _word;
    private int _times;
    private string[] _separators = {",", ".", "!", "?", ";", ":", " "};
    private string[] _wordArray;

    private static List<WordCounterScore> _instances = new List<WordCounterScore> {};

    public WordCounterScore(string word, int times = 0)
    {
      _word = word;
      _times = times;
    }
    public string GetWord()
    {
      _word = _word.ToLower();
      return _word;
    }
    public string GetText()
    {
      _text = _text.ToLower();
      return _text;
    }
    public string[] GetWords()
    {
      _wordArray = _text.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
      return _wordArray;
    }
    public int GetTimes()
    {
      foreach ( string appearance in _wordArray)
      if(appearance == _word)
      {
        _times++;
      }
      return _times;
    }
    public static List<WordCounterScore> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

    // public void FindWord()
    // {
    //   int numberOfTimes = 0;
    //
    //   Console.WriteLine("Enter a word: ");
    //   string userWord = Console.ReadLine();
    //   userWord = userWord.ToLower();
    //   Console.WriteLine("Your word is: " + userWord);
    //
    //   Console.WriteLine("Now enter and sentence and I will tell you how many times your word occurs: ");
    //   string userPhrase = Console.ReadLine();
    //   userPhrase = userPhrase.ToLower();
    //   string[] separators = {",", ".", "!", "?", ";", ":", " "};
    //   string[] words = userPhrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    //
    //   foreach (string word in words)
    //   if(word == userWord)
    //   {
    //     numberOfTimes++;
    //   }
    //   Console.WriteLine("The word you entered occurs " + numberOfTimes + " times.");
    // }

  }
}
