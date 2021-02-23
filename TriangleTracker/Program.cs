using System;
using System.Collections.Generic;
// using System.Convert;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Side1:");
      string sideString1 = Console.ReadLine();
      int side1 = int.Parse(sideString1);
      Console.WriteLine("Enter Side2:");
      string sideString2 = Console.ReadLine();
      int side2 = int.Parse(sideString2);
      Console.WriteLine("Enter Side3:");
      string sideString3 = Console.ReadLine();
      int side3 = int.Parse(sideString3);

      Triangle triangle = new Triangle(side1, side2, side3);

      if(triangle.IsTriangle()){
        string triangleLable = triangle.checkType();
        Console.WriteLine(triangleLable);
      }
      else {
        Console.WriteLine("3 Sides you entered do not constitute a triangle");
      }

    }
  }
}