using System.Collections.Generic;
using System;

namespace RectangleStuff
{
  public class Rectangle
  {
    private int _length;
    private int _width;
    ///constructor function
    public Rectangle(int length, int width)
    {
      _length = length;
      _width = width;
    }
    ////getter functions
    public int GetLength()
    {
    return _length;
    }

    public int GetWidth()
    {
      return _width;
    }

    public int GetArea()
    {
      return _width * _length;
    }
    ////True false square function

    public bool Issquare()
    {
      if (_length == _width)
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
