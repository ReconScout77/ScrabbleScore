using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
    public class Scrabble
    {
      private static Dictionary<int, List<char>> _dictionary = new Dictionary<int, List<char>>()
      {
          {1, new List<char>{'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}},
          {2, new List<char>{'D', 'G'}},
          {3, new List<char>{'B', 'C', 'M', 'P'}},
          {4, new List<char>{'F', 'H', 'V', 'W', 'Y'}},
          {5, new List<char>{'K'}},
          {8, new List<char>{'J', 'X'}},
          {10, new List<char>{'Q', 'Z'}}
      }; 
      private string _userWord;
      private int _scoreTotal;

      public Scrabble (string inputWord)
      {
          _userWord = inputWord;
      }

      public void SetScore(int newScore)
      {
          _scoreTotal = newScore;
      }

      public int GetScore()
      {
          return _scoreTotal;
      }

      public string GetWord()
      {
          return _userWord;
      }
     
      public int CaculateScrabbleScore()
      {
          char[] userInputCharArr = _userWord.ToCharArray();
          foreach(KeyValuePair<int, List<char>> kvp in _dictionary)
          {
              List<char> tempCharList = kvp.Value;
              Console.WriteLine(tempCharList.ToString());
              
              Console.WriteLine("user input" + String.Join("", userInputCharArr));
              Console.WriteLine(kvp.Key);
              for(int i=0; i<userInputCharArr.Length; i++)
              {
                if(tempCharList.Contains(Char.ToUpper(userInputCharArr[i])))
                {
                    _scoreTotal += kvp.Key;
                }
              }
          }
          return _scoreTotal;
      }
    }
}