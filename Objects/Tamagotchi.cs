using System.Collections.Generic;
using System;

namespace Tamagotchilife
{
    public class Tamagotchi
    {
      /// private variables
      private string _name;
      private int _food;
      private int _sleep;
      private int _philosophy;
      private int _id;
      // private static List<Tamagotchi> _TamoList = new List<Tamagotchi>(){};
      /////constructor function
      public Tamagotchi(string name)
      {
        _name = name;
        _food = 10;
        _sleep = 10;
        _philosophy = 10;
        // _id = _totalTama;
        // _TamoList.Add(this);
        // _totalTama += 1;


      }
      // Create Empty List
    public string GetName()
    {
      return _name;
    }

    public int GetFood()
    {
      return _food;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public int GetPhilosophy()
    {
      return _philosophy;
    }
    public int GetId()
{
  return _id;
}
////List All function
// public static Tamagotchi Find(int searchId)
// {
//   return _Tamolist[searchId-1];
// }

    //Life Sustaining functions
    public int Feed()
    {
      _food = _food + 3;
      _sleep =_sleep - 1;
      _philosophy =_philosophy - 1;
      return _food;
    }
    // public int Sleeping()
    // {
    //   _food =_food -1;
    //   _slee
    // }


    //Get All method
    public static List<Tamagotchi>GetAll()
    {
      return _TamoList;
    }

    /// death true false function
    public bool Zombigochi()
    {
      if ( (_food == 0) || (_sleep == 0) || (_philosophy ==0) )
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
