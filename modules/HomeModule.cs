using Nancy;
using FindReplaceNS.Objects;
using System.Collections.Generic;

namespace FindReplaceNMS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/"]= _ =>
      {
        FindReplace newPhrase = new FindReplace(Request.Form["phrase"],
        Request.Form["wordToReplace"],
        Request.Form["newWord"]);
        return View["index.cshtml", newPhrase];
      };
    }
  }
}
