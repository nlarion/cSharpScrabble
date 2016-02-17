using Xunit;
using PalindromeNS.Objects;
using System.Collections.Generic;
using System;

namespace PalindromeTestNS
{
  public class PalindromeTest
  {
    [Fact]
    public void Reverse_The_Word()
    {
      Palindrome test = new Palindrome("hey");
      Assert.Equal("yeh", test.Reverse());
    }


  }
}
