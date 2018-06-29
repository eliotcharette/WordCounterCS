using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounterName;
using System;

namespace WordCounterName.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    // [TestMethod]
    // public void WordCounterScore_FindWordOnce_Equal()
    // {
    //   WordCounterScore newWord = new WordCounterScore();
    //   int result = newWord.FindWord("hello");
    //   int score = newWord.GetScore();
    //   Assert.AreEqual(score, 0);
    // }
    [TestMethod]
    public void Matching_ReturnInput_String()
    {
      string input = "hello";
      WordCounterScore newWord = new WordCounterScore(input);

      string result = newWord.Matching();

      Assert.AreEqual(input, result);
    }
  }
}
