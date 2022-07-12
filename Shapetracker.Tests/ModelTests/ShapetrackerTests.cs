using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class ShapeTrackerTests
  {
     [TestMethod]
    public void TriangleType_CheckToSeeIfTriangle_IsEquilateral()
    {
      Triangle testTriangle = new Triangle(1, 1, 1);
      Assert.AreEqual("equilateral", testTriangle.TriangleType());
    }
    [TestMethod]
    public void TriangleType_CheckToSeeIfTriangle_IsIsosceles()
    {
      Triangle testTriangle = new Triangle(2, 2, 8);
      Assert.AreEqual("isosceles", testTriangle.TriangleType());
    }
     [TestMethod]
    public void TriangleType_CheckToSeeIfTriangle_IsScalene()
    {
      Triangle testTriangle = new Triangle(2, 4, 8);
      Assert.AreEqual("scalene", testTriangle.TriangleType());
    }
  }
}  