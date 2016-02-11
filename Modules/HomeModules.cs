using Nancy;
using System.Collections.Generic;
using System;
using Tamagotchilife;

namespace TamagotchiNamespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
            return View ["create_tamo.cshtml"];
          };
      Post["/tamo_list"] =_=>  {
        // List<Tamagotchi> zombitamo = new List <string,object>();
        Tamagotchi myownTamo = new Tamagotchi(Request.Form["create"]);
        List<Tamagotchi> TamoList = Tamagotchi.GetAll();


        // if (myownTamo.Zombigochi()) {
        //   Tamagotchi myownTamo = new Tamagotchi (myownTamo);
        //   zombitamo.Add("ResultingTamo", myownTamo);
        // }
        return View["tamo_list.cshtml", TamoList];
    };

    Post["/new_tamo_list"] = _ => {
        Tamagotchi newTamo = new Tamagotchi(Request.Form["John"]);
        newTamo.Feed();
        List<Tamagotchi> TamoList = Tamagotchi.GetAll();
        return View["tamo_list.cshtml", newTamo];
      };
    }
  }
}
