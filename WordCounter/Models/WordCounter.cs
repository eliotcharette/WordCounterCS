using System;
using System.Collections.Generic;

namespace WordCounterName
{
  public class WordCounterScore
  {
    public int numberOfTimes = 0;
    //private string _input;

    // public WordCounterScore()
    // {
    //
    // }
    public void Run()
    {
      Console.WriteLine("Enter a word and I will tell you how many times it occurs in your sentence: ");
      string userWord = Console.ReadLine();
      userWord = userWord.ToLower();
    }
    public int FindWord(string userWord)
    {
      //foreach(string inputWord in userWord)
      //{
        if(userWord == "hello")
        {
          numberOfTimes++;
          return numberOfTimes;
        }
        else
        {
          return 0;
        }
      //}
    }
    public int GetScore()
    {
      return numberOfTimes;
    }
  }
  public class Program
  {
    public static void Main()
    {
      WordCounterScore newWord = new WordCounterScore();
      newWord.Run();
    }
  }
}
