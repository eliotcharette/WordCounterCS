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
    public void Run()
    {
      Console.WriteLine("Enter a word and I will tell you how many times it occurs in your sentence: ");
      string userWord = Console.ReadLine();
      userWord = userWord.ToLower();
      // string[] words = userWord.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);

      // foreach(userWord in words)
      // {
      }
      public int FindWord(string userWord)
      {
        if(userWord == "hello")
        {
          numberOfTimes++;
          Console.WriteLine(numberOfTimes);
        }
        else
        {
          Console.WriteLine(10);
        }
      }
    // }
    // public int FindWord(string userWord)
    // {
    //     if(userWord == "hello")
    //     {
    //       numberOfTimes++;
    //       return numberOfTimes;
    //     }
    //     else
    //     {
    //       return 10;
    //     }
    // }
    // public int GetScore()
    // {
    //   return numberOfTimes;
    // }
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
