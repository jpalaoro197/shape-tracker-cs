using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class ShapeTrackerTests
  {
     [TestMethod]
    public void TriangleType_CheckToSeeIfSidesAreEqual_Equilateral()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual("equilateral", testTriangle.TriangleType());
    }

    [TestMethod]
    public void TriangleType_CheckToSeeIf2SidesAreEqual_Isosceles()
    {
      Triangle testTriangle = new Triangle(3, 3, 1);
      Assert.AreEqual("isosceles", testTriangle.TriangleType());
    }

    [TestMethod]
    public void TriangleType_CheckToSeeIfSidesNotEqual_Scalene()
    {
      Triangle testTriangle = new Triangle(4,3,5);
      Assert.AreEqual("scalene", testTriangle.TriangleType());
    }

    [TestMethod]
    public void TriangleType_CheckToSeeIfTraingle_NotATriangle()
    {
      Triangle testTriangle = new Triangle(1, 2, 8);
      Assert.AreEqual("not a triangle", testTriangle.TriangleType());
    }
  }
}  