using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounterName;
using System;

namespace WordCounterName.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void WordCounterScore_FindWordOnce_Equal()
    {
      WordCounterScore newWord = new WordCounterScore();
      int expectedResult = 1;
      string test = "hello";
      Assert.AreEqual(expectedResult, newWord.FindWord(test));
    }
    // [TestMethod]
    // public void Matching_ReturnInput_String()
    // {
    //   string input = "hello";
    //   WordCounterScore newWord = new WordCounterScore(input);
    //
    //   string result = newWord.Matching();
    //
    //   Assert.AreEqual(input, result);
    // }
  }
}
