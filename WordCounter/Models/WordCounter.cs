using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounterName
{
  public class WordCounterScore
  {
    private string _word;
    private string _text;
    private int _times;

    private static List<WordCounterScore> _instances = new List<WordCounterScore> {};

    public WordCounterScore(string word, string text, int times = 0)
    {
      _word = word;
      _text = text;
      _times = times;
    }
    public string GetWord()
    {
      _word = _word.ToLower();
      return _word;
    }
    public string GetText()
    {
      return _text;
    }
    public int GetTimes()
    {
      string[] _wordArray = _text.ToLower().Split(',','.','!','?',':',';',' ');

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
  }
}
