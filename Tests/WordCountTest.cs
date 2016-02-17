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
    public void Find_And_Replace_Words_Within_Words_With_Capitals()
    {
      FindReplace test3 = new FindReplace("Catdog", "cat", "wolf");
      Assert.Equal("wolfdog", test3.ReplaceWord());
    }

    [Fact]
    public void Find_Number_Of_Times_Word_Exists()
    {
      FindReplace test4 = new FindReplace("cat cat cat dog", "cat", "wolf");
      Assert.Equal(3, test4.CountWord());
    }

    [Fact]
    public void Prevent_Partial_Replacements()
    {
      FindReplace test5 = new FindReplace("catdog", "cat", "wolf");
      Assert.Equal("catdog", test5.WholeWordsOnly());
    }

    [Fact]
    public void Prevent_Partial_Replacements_While_Allowing_Single()
    {
      FindReplace test5 = new FindReplace("I am walking my cat to the cathedral", "cat", "wolf");
      Assert.Equal("I am walking my wolf to the cathedral", test5.WholeWordsOnly());
    }

   //need one more test to have CountWord() method count capitalized letters.

  }
}
