using Nancy;
using Parcels.Objects;

namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];


      Get["/output"] = _ => {
        ParcelVariables newInput = new ParcelVariables
        {
          Length = Request.Query["length"],
          Width = Request.Query["width"],
          Height = Request.Query["height"],
          Weight = Request.Query["weight"],
          Distance = Request.Query["distance"]
        };
        return View["output.cshtml", newInput];
      };
    }
  }
}
