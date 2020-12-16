using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouveBeen.Models;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newEmptyList = new List<Place> {};
      // /*creates a new place "test" and automatically adds it to _instances list*/ " Place newPlace = new Place("test"); "
      //code on line 26 will correctly fail test we are putting 'test' into a list that should be returning empty 'at this time'
      /*returns _instaces list and saves as result*/ 
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newEmptyList, result);
    }


  }
}