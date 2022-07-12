namespace ShapeTracker
{
  public class Triangle
  {
    private int side1;
    private int side2;
    private int side3;

    public Triangle(int _side1, int _side2, int _side3)
    {
      side1 = _side1;
      side2 = _side2;
      side3 = _side3;
    }
    public string TriangleType()
    {
      if ((side1 + side2) <= side3 || (side2 + side3) <= side1 || (side1 + side3) <= side2) {
        return "not a triangle";
      }
      else if ((side1 == side2) && (side2 == side3) && (side1 == side3)) 
      {
        return "equilateral";
      }
      else if ((side1 == side2) || (side2 == side3) || (side1 == side3))
      {
        return "isosceles";
      }
      else 
      {
        return "scalene";
      }
    }
  }
}