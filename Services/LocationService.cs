using System.Collections.Generic;

namespace MvcApp.Services
{
  public class LocationService
  {
    public List<string> GetLocationList()
    {
      return new List<string>
        {
          "Hanoi",
          "Thanh Hoa",
          "Hai Phong",
          "Nghe An",
          "TP HCM"
        };
    }
  }
}