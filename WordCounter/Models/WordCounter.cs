using System;

namespace WordPhrase.Models
{
  public class RepeatCounter
  {
    public string UserWord { get; set; }
    public string UserPhrase { get; set; }
    public RepeatCounter(string word, string phrase)
    {
      UserWord = word;
      UserPhrase = phrase;
    }

    public bool InputChecker()
    {
      if (String.IsNullOrWhiteSpace(UserWord) == true)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public string PunctuationRemover(string str)
    { 
      for(int i = 0; i < str.Length; i++)
      {
        if (Char.IsPunctuation(str[i]) == true)
        {
          str = str.Replace(str[i], ' ');
        }
      }
      return str;
    }

    public int OccurrenceCounter()
    {
      int counter = 0;
      string word = UserWord.ToLower();
      string phrase = UserPhrase.ToLower();
      string[] phraseArray = UserPhrase.Split(" ");
      foreach(string phraseItem in phraseArray)
      {
        if (phraseItem == word)
        {
          counter++;
        }
      }
      return counter;
    }
  }
}