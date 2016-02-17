using Xunit;
using FindReplaceNS.Objects;
using System.Collections.Generic;
using System;

namespace FindReplaceTestNS
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void Find_And_Replace_Test()
    {
      FindReplace test = new FindReplace("hello world", "world", "universe");
      Assert.Equal("hello universe", test.ReplaceWord());
    }

    [Fact]
    public void Find_And_Replace_Whole_phrase()
    {
      FindReplace test2 = new FindReplace("hello world", "hello world", "universe");
      Assert.Equal("universe", test2.ReplaceWord());
    }

    [Fact]
    public void Find_And_Replace_Words_Within_Words()
    {
      FindReplace test3 = new FindReplace("catdog", "cat", "wolf");
      Assert.Equal("wolfdog", test3.ReplaceWord());
    }

    [Fact]
    public void Find_And_Replace_Words_Within_Words_With_Capitals()
    {
      FindReplace test3 = new FindReplace("Catdog", "cat", "wolf");
      Assert.Equal("wolfdog", test3.ReplaceWord());
    }

    [Fact]
    public void Find_Number_Of_Times_Word_Exists()
    {
      FindReplace test3 = new FindReplace("Cat cat cat", "cat", "wolf");
      Assert.Equal(3, test3.CountWord());
    }

   //should also have test for capital letters and replacing numbers.

  }
}
