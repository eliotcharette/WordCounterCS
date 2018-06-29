using System;
using System.Collections.Generic;

namespace WordCounterName
{
  public class WordCounterScore
  {
  //  public int numberOfTimes = 0;
    private string _input;

    public WordCounterScore (string input)
    {
      _input = input;
    }
    public string Matching()
    {
      return _input;
    }

    // public void FindWord(string inputWord)
    // {
    //   foreach(string inputWord in userWord)
    //   {
    //     if(inputWord == userWord)
    //     {
    //       numberOfTimes++;
    //     }
    //   }
    // }
    // public int GetScore()
    // {
    //   return numberOfTimes;
    // }
  }
  // public class Program
  // {
  //   public static void Main()
  //   {
  //     WordCounterScore newWord = new WordCounterScore();
  //     Console.WriteLine("Enter a word and I will tell you how many times it occurs in your sentence: ");
  //     string userWord = Console.ReadLine();
  //     userWord = userWord.ToLower();
  //
  //   }
  // }
}
