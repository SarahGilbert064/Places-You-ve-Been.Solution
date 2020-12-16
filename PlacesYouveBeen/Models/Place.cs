using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public string Date { get; set; }

    public string Entry { get; set; }

    public int Id { get; }

    private static List<Place> _instances = new List<Place> {};

    public Place(string cityName, string date, string entry)
    {
      CityName = cityName;
      Date = date;
      Entry = entry;
      //top 3 lines are not needed technically as they are get/set in the property
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}