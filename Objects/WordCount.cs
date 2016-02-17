using System.Collections.Generic;
using System;
using System.Linq;

namespace FindReplaceNS.Objects
{
  public class FindReplace
    {
        private string _phrase;
        private string _wordToReplace;
        private string _newWord;

        public FindReplace (string phrase, string wordToReplace, string newWord)
        {
          _phrase = phrase;
          _wordToReplace = wordToReplace;
          _newWord = newWord;
        }

        public string ReplaceWord()
        {
         string newPhrase = _phrase.ToLower();
         string result = newPhrase.Replace(_wordToReplace, _newWord);
         return result;
        }

        public int CountWord()
        {
         return 0;
        }
  }
}