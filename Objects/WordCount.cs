using System.Collections.Generic;
using System;
using System.Linq;

namespace PalindromeNS.Objects
{
  public class Palindrome
    {
        private string _phrase;
        private string _inversePhrase;


        public Palindrome (string phrase)
        {
          _phrase = phrase;
        }

        public string Reverse()
        {
          string inversePhrase;

          char[] phraseArray = _phrase.ToCharArray();
          var reverse = phraseArray.Reverse();

          inversePhrase = string.Join("", reverse);
          Console.WriteLine(inversePhrase);
          _inversePhrase = inversePhrase;
          _phrase = _phrase.Replace(" ", "");
          _inversePhrase = _inversePhrase.Replace(" ",  "");
          return inversePhrase;
        }

        public bool Compare()
        {
         if (_phrase == _inversePhrase)
         {
           return true;
         }
         else
         {
           return false;
         }

        }



  }
}
