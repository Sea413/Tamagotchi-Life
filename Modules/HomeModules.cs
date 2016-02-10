using Nancy;
using System.Collections.Generic;
using System;
using RectangleStuff;
using CubeNamespace;




namespace shapeNamespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View ["rectangle_form.cshtml"];
      };
      // Get ["/rectangle_result"]=_=>{
      //   Rectangle myRectangle = new Rectangle (Request.Query ["side-length"], Request.Query["side-width"]);
      //   return View ["rectangle_result.cshtml", myRectangle];
      // };
      Get["/rectangle_result"]=_=>  {
        Dictionary <string, object> whistle = new Dictionary <string,object>();

        Rectangle myownRectangle = new Rectangle(Request.Query["side-length"],Request.Query["side-width"]);

        whistle.Add("ResultingRectangle", myownRectangle);

        if (myownRectangle.Issquare()) {
          Cube myCube = new Cube (myownRectangle);
          whistle.Add("ResultingCube", myCube);
          Console.WriteLine(whistle);
        }
        return View["rectangle_result.cshtml",whistle];
      };
    }
  }
}
