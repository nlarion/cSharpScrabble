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

    [Fact]
    public void Reverse_The_Word_Then_Compare_Original_false()
    {
      Palindrome test = new Palindrome("hey");
      test.Reverse();
      Assert.Equal(false, test.Compare());
    }

    [Fact]
    public void Reverse_The_Word_Then_Compare_Original_true()
    {
      Palindrome test = new Palindrome("bob");
      test.Reverse();
      Assert.Equal(true, test.Compare());

    }



  }
}
