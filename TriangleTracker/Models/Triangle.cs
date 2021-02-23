using System;

namespace TriangleTracker
{
  public class Triangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    public Triangle(int side1, int side2, int side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }
    public bool IsTriangle()
    {
      if ((Side1 + Side2 > Side3) && (Side2 + Side3 > Side1) && (Side1 + Side3 > Side2))
      {
        // Console.WriteLine(Side1 + " " +Side2 + " " +Side3);
        return true;
      }
    else
      return false;
    }

    public string checkType()
    {
      if ((Side1 == Side2) && (Side2 == Side3) && (Side1 == Side3)) {
        return "Equilatertal Triangle";
      }
      else if ((Side1 == Side2) || (Side2 == Side3) || (Side1 == Side3)) {
        return "Isosceles Triangle";
      }
      else {
        return "Scalene Triangle";
      }
    }
  }
}