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
      FindReplace testReplace = new FindReplace("hello world", "world", "universe");

      Assert.Equal("hello universe", FindReplace.ReplaceWord());
    }


  }
}
