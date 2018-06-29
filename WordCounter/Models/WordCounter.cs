using System;
using System.Collections.Generic;

namespace WordCounterName
{
  public class WordCounterScore
  {
    public int numberOfTimes = 0;

    public WordCounterScore()
    {

    }

  }
  public class Program
  {
    public static void Main()
    {
      //WordCounterScore newWord = new WordCounterScore();
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
