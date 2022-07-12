using System;
using System.Collections.Generic;
using ShapeTracker;


namespace ShapeTracker
{
  public class program
  {
    public static void Main()
    {
      Console.WriteLine("enter side 1");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("enter side 2");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("enter side 3");
      int side3 = int.Parse(Console.ReadLine());
      Triangle checkTriangle = new Triangle(side1, side2, side3);
      Console.WriteLine(checkTriangle.TriangleType());
    }
  }
}