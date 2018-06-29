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
    public void FindWord(string userWord)
    {


      if(userWord == "hello")
      {
        numberOfTimes++;
      }
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
      Console.WriteLine("Enter a word");
      string userWord = Console.ReadLine();
      userWord = userWord.ToLower();
      newWord.FindWord(userWord);
      int score = newWord.GetScore();
      Console.WriteLine(score);
    }
  }
}
