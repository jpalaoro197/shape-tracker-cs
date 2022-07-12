using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class ShapeTrackerTests
  {
    [TestMethod]
    public void TriangleType_CheckToSeeIfTriangle_NotATriangle()
    {
      Triangle testTriangle = new Triangle(1, 2, 8);
      Assert.AreEqual("not a triangle", testTriangle.TriangleType());
    }
     [TestMethod]
    public void TriangleType_CheckToSeeIfTriangle_IsEquilateral()
    {
      Triangle testTriangle = new Triangle(1, 1, 1);
      Assert.AreEqual("equilateral", testTriangle.TriangleType());
    }
  }
}  